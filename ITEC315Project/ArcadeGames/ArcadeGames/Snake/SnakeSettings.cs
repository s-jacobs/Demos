using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcadeGames {
    class SnakeSettings {
        public static int width { get; set; }
        public static int height { get; set; }
        public static string directions;

        public SnakeSettings() {
            //default width and height for snake part
            width = 16;
            height = 16;
            //default direction snake travels
            directions = "left";
        }

    }
}
