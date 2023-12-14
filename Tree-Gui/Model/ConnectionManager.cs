using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAPI;
using TreeAPI.Config;
using TreeAPI.Types;

namespace Tree_Gui.Model {
    internal static class ConnectionManager {

        static Tree? tree;


        public static Animation? CurrentAnimation { get; private set; } = null; 
        public static string Path { get; private set; } = "";
        public static bool IsTesting { get; private set; }
        public static bool? IsConnected { get => tree?.IsConnected; }
        public static void Connect(string IP, int port) {
            ConfigManager.IP = IP;
            ConfigManager.Port = port;

            tree = new Tree();
        }
    }
}
