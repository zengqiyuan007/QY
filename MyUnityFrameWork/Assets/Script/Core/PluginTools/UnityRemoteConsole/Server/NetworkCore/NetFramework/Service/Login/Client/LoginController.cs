﻿using SimpleNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace SimpleNetManager
{
    public class LoginController : ClientControllerBase
    {
        private bool isLogin;
        public bool IsLogin
        {
            get
            {
                return isLogin;
            }
        }

        public Action<Login2Client> Onlogin;
        public Action<Logout2Client> OnLogout;
        public override void OnInit()
        {
            netManager.MsgManager.RegisterMsgEvent<Login2Client>(OnLoginEvent);
            netManager.MsgManager.RegisterMsgEvent<Logout2Client>(OnLogoutEvent);
            netManager.OnNetConnectStateChange += OnNetConnectStateChange;
        }

        private void OnNetConnectStateChange(NetConnectState state, EDisconnectInfo arg2)
        {
            if(state== NetConnectState.DisConnected)
            {
                //Debug.Log("断开连接！");
                RemovePlayer();
            }
        }
        public override void OnStop()
        {
            netManager.MsgManager.UnregisterMsgEvent<Login2Client>(OnLoginEvent);
            netManager.MsgManager.UnregisterMsgEvent<Logout2Client>(OnLogoutEvent);
            netManager.OnNetConnectStateChange -= OnNetConnectStateChange;
        }
        private void RemovePlayer()
        {
            if (netManager == null || netManager.Session == null)
                return;
            Player player = SimpleNetManager.PlayerManager.GetPlayer(netManager.Session);
            if (player != null)
            {
                SimpleNetManager.PlayerManager.RemovePlayer(player);
            }
            isLogin = false;
        }
        private void OnLogoutEvent(NetMessageData messageHandler)
        {
            Debug.Log("客户端接收登出");
            if (IsLogin)
            {
               
                Logout2Client msg = messageHandler.GetMessage<Logout2Client>();
                if (OnLogout != null)
                {
                    OnLogout(msg);
                }
                RemovePlayer();
            }
        }

        private void OnLoginEvent(NetMessageData messageHandler)
        {
            Login2Client msg = messageHandler.GetMessage<Login2Client>();
            if (msg.code == 0)
            {
                isLogin = true;
                if(string.IsNullOrEmpty(msg.playerID))
                {
                    msg.playerID = "001";
                }
                Player player = new Player(messageHandler.session);
                player.playerID = msg.playerID;
                player.AddData(msg.appData);

                SimpleNetManager.PlayerManager.AddPlayer(player);

            }
            if (Onlogin != null)
            {
                Onlogin(msg);
            }
            Debug.Log("登录返回:" + msg.code);
        }

        private string key;
        private string password;
        public void LoginByAccount(string key,string password)
        {
            this.key = key;
            this.password = password;

            string mixed=null;
            //加密密码
            if (!string.IsNullOrEmpty(password))
            {
                string aesKey = Encoding.UTF8.GetString(AESUtils.GetRandomKey(32));
                string pwMD5 = MD5Tool.GetObjectMD5(password);
                string md5Ery = AESUtils.AESEncrypt(pwMD5, aesKey);
                string length = md5Ery.Length.ToString().PadLeft(4, '0');
                 mixed = length + md5Ery + aesKey;
                //Debug.Log("aesKey:" + aesKey);
                //Debug.Log("md5Ery:" + md5Ery);
                //Debug.Log("Mixed:" + mixed);
            }
            Login2Server msg = new Login2Server();
            msg.loginType = LoginType.Account;
            msg.key = key;
            msg.password = mixed;
          bool res=  netManager.Send(msg);
            Debug.Log("Send Res:" + res);
        }

        public void ReLogin()
        {
            if (string.IsNullOrEmpty(key))
            {
                Debug.LogError("No record key password to login!");
                return;
            }
            LoginByAccount(key, password);
        }
        public void Logout()
        {
            if (IsLogin)
            {
                netManager.Send(new Logout2Server());
            }
        }
    }
}
