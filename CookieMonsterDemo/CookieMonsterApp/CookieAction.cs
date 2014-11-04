/**
 * CookieMonsterAction
 * Just a struct class to package history info
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookieMonster;

namespace CookieMonster
	{
	public class CookieMonsterAction
		{
		public ICookie Cookie { get; set; }
		public CookieAction Action { get; set; }
		public DateTime Time {  get; set; }

		public CookieMonsterAction( ICookie cookie, CookieAction cookieAction )
			{
			Cookie = cookie;
			Action = cookieAction;
			Time = DateTime.Now;
			}
		}
	}
