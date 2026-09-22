using System.Runtime.InteropServices;

namespace Test;

public static partial class Program
{
	[DllImport("luajit", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr luaL_newstate();

	public static void Main(string[] args)
	{
		var l = luaL_newstate();
	}
}