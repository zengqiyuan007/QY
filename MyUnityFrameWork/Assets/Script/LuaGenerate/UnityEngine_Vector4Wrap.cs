﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Vector4Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Vector4), null);
		L.RegFunction(".geti", get_Item);
		L.RegFunction("get_Item", get_Item);
		L.RegFunction(".seti", set_Item);
		L.RegFunction("set_Item", set_Item);
		L.RegFunction("Set", Set);
		L.RegFunction("Lerp", Lerp);
		L.RegFunction("LerpUnclamped", LerpUnclamped);
		L.RegFunction("MoveTowards", MoveTowards);
		L.RegFunction("Scale", Scale);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("Equals", Equals);
		L.RegFunction("Normalize", Normalize);
		L.RegFunction("Dot", Dot);
		L.RegFunction("Project", Project);
		L.RegFunction("Distance", Distance);
		L.RegFunction("Magnitude", Magnitude);
		L.RegFunction("Min", Min);
		L.RegFunction("Max", Max);
		L.RegFunction("ToString", ToString);
		L.RegFunction("SqrMagnitude", SqrMagnitude);
		L.RegFunction("New", _CreateUnityEngine_Vector4);
		L.RegVar("this", _this, null);
		L.RegFunction("__add", op_Addition);
		L.RegFunction("__sub", op_Subtraction);
		L.RegFunction("__mul", op_Multiply);
		L.RegFunction("__div", op_Division);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__unm", op_UnaryNegation);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("kEpsilon", 9.99999974737875E-06);
		L.RegVar("x", get_x, set_x);
		L.RegVar("y", get_y, set_y);
		L.RegVar("z", get_z, set_z);
		L.RegVar("w", get_w, set_w);
		L.RegVar("normalized", get_normalized, null);
		L.RegVar("magnitude", get_magnitude, null);
		L.RegVar("sqrMagnitude", get_sqrMagnitude, null);
		L.RegVar("zero", get_zero, null);
		L.RegVar("one", get_one, null);
		L.RegVar("positiveInfinity", get_positiveInfinity, null);
		L.RegVar("negativeInfinity", get_negativeInfinity, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Vector4(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.Vector4 obj = new UnityEngine.Vector4(arg0, arg1);
				ToLua.Push(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(float), typeof(float), typeof(float)))
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Vector4 obj = new UnityEngine.Vector4(arg0, arg1, arg2);
				ToLua.Push(L, obj);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(float), typeof(float), typeof(float), typeof(float)))
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Vector4 obj = new UnityEngine.Vector4(arg0, arg1, arg2, arg3);
				ToLua.Push(L, obj);
				return 1;
			}
			else if (count == 0)
			{
				UnityEngine.Vector4 obj = new UnityEngine.Vector4();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Vector4.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = obj[arg0];
			LuaDLL.lua_pushnumber(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _set_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj[arg0] = arg1;
			ToLua.SetBack(L, 1, obj);
			return 0;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, _set_this);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = obj[arg0];
			LuaDLL.lua_pushnumber(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj[arg0] = arg1;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Set(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
			obj.Set(arg0, arg1, arg2, arg3);
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lerp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Vector4 o = UnityEngine.Vector4.Lerp(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LerpUnclamped(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Vector4 o = UnityEngine.Vector4.LerpUnclamped(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveTowards(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Vector4 o = UnityEngine.Vector4.MoveTowards(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Scale(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			obj.Scale(arg0);
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.ToObject(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj.Equals(arg0);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Normalize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			obj.Normalize();
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dot(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			float o = UnityEngine.Vector4.Dot(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Project(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 o = UnityEngine.Vector4.Project(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Distance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			float o = UnityEngine.Vector4.Distance(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Magnitude(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			float o = UnityEngine.Vector4.Magnitude(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Min(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 o = UnityEngine.Vector4.Min(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Max(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 o = UnityEngine.Vector4.Max(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Addition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 o = arg0 + arg1;
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Subtraction(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 o = arg0 - arg1;
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_UnaryNegation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			UnityEngine.Vector4 o = -arg0;
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Multiply(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(float), typeof(UnityEngine.Vector4)))
			{
				float arg0 = (float)LuaDLL.lua_tonumber(L, 1);
				UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.ToObject(L, 2);
				UnityEngine.Vector4 o = arg0 * arg1;
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector4), typeof(float)))
			{
				UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.ToObject(L, 1);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Vector4 o = arg0 * arg1;
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Vector4.op_Multiply");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Division(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector4 o = arg0 / arg1;
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)ToLua.ToObject(L, 1);
			UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector4)))
			{
				UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.ToObject(L, 1);
				string o = obj.ToString();
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector4), typeof(string)))
			{
				UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string o = obj.ToString(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Vector4.ToString");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SqrMagnitude(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)ToLua.CheckObject(L, 1, typeof(UnityEngine.Vector4));
			float o = obj.SqrMagnitude();
			LuaDLL.lua_pushnumber(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float ret = obj.x;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index x on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float ret = obj.y;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index y on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float ret = obj.z;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index z on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_w(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float ret = obj.w;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index w on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normalized(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			UnityEngine.Vector4 ret = obj.normalized;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index normalized on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_magnitude(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float ret = obj.magnitude;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index magnitude on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sqrMagnitude(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float ret = obj.sqrMagnitude;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index sqrMagnitude on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_zero(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Vector4.zero);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_one(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Vector4.one);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_positiveInfinity(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Vector4.positiveInfinity);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_negativeInfinity(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Vector4.negativeInfinity);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_x(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.x = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index x on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_y(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.y = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index y on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_z(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.z = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index z on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_w(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Vector4 obj = (UnityEngine.Vector4)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.w = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index w on a nil value" : e.Message);
		}
	}
}

