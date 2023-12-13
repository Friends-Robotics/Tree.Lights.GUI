using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAPI;

namespace Tree_Gui.Model {
    internal static class ConnectionManager {
        
        static ConnectionManager() {

        }


        public static Animation? CurrentAnimation { get; private set; } = null; 
        public static string Path { get; set; } = "";
        public static bool IsTesting { get; set; }
        public static bool IsConnected { get; private set; }
        public static void Connect(string IP, string port) {
            IsConnected = false;
            throw new NotImplementedException("Cannot connect to the tree because the its not implemented");
        }
    }
}
