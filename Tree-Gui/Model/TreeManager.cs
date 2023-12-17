using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TreeAPI;
using TreeAPI.Config;
using TreeAPI.Types;

namespace Tree_Gui.Model {
    internal static class TreeManager {

        // This is all rudimentary code to simulate what woulf actually happen if the tree could connect

        static Tree? tree;
        public static Animation? CurrentAnimation { get; private set; } = null; 
        public static string Path { get; private set; } = "";
        public static bool IsTesting { get; private set; }
        public static bool? IsConnected { get => tree?.IsConnected; }
        public static void Connect(string IP, int port) {
            IpAddr i = new() {
                Address = IP,
                Port = port,
                Path = "Ping"
            };

            tree = new Tree(i);
            
        }


    }
}
