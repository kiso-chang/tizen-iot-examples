﻿using System.Runtime.CompilerServices;

namespace SoundSensor
{
    public static class Logger
    {

        private const string LOGTAG = "LOGSENSOR";
        public static void Debug(string message, [CallerFilePath] string file = "", [CallerMemberName] string func = "", [CallerLineNumber] int line = 0)
        {
            global::Tizen.Log.Debug(LOGTAG, message, file, func, line);
        }
        public static void Error(string message, [CallerFilePath] string file = "", [CallerMemberName] string func = "", [CallerLineNumber] int line = 0)
        {
            global::Tizen.Log.Error(LOGTAG, message, file, func, line);

        }

		/* ****************************************************************
		 * print bar
		 ******************************************************************/

		private const string LOGTAG_SBAR = "SOUNDBAR";

		private const int BAR_VALUE_MAX = 1023;
		public static void print_bar(uint val)
		{
			if (val > BAR_VALUE_MAX)
				val = BAR_VALUE_MAX;

			global::Tizen.Log.Debug(LOGTAG_SBAR, log_bar[val / 8] + "  " + val.ToString(), "", "", 0);
		}

		
		private static string[] log_bar = {
			"|",
			"||",
			"|||",
			"||||",
			"|||||",
			"||||||",
			"|||||||",
			"||||||||",
			"|||||||||",
			"||||||||||",
			"|||||||||||",
			"||||||||||||",
			"|||||||||||||",
			"||||||||||||||",
			"|||||||||||||||",
			"||||||||||||||||",
			"|||||||||||||||||",
			"||||||||||||||||||",
			"|||||||||||||||||||",
			"||||||||||||||||||||",
			"|||||||||||||||||||||",
			"||||||||||||||||||||||",
			"|||||||||||||||||||||||",
			"||||||||||||||||||||||||",
			"|||||||||||||||||||||||||",
			"||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||",
			"||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||"
		};


	}
}