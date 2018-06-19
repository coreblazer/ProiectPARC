using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemoteProtocol.Entities;
using RemoteProtocol;
using RemoteProtocol.Game;

namespace RemoteProtocol {
    public class Joc {
        private static int _globalID = 0;

        public   User Player1 { get; }
        public   User Player2 { get; }
        public int GameSize = 4;
        public int GameID { get; }

        public Joc(int v, User player1, User player2) {
            Player1 = player1;
            Player2 = player2;
            GameID = _globalID++;

            StartGame();
        }

        public Joc()
        {
        }

        private void StartGame() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //a.ShowDialog();
           Server.Instance.SendMessage(new TestRequest($"Joc id is {GameID}"), Player1.ClientStream);
            Server.Instance.SendMessage(new TestRequest($"Joc id is {GameID}"), Player2.ClientStream);
        }
    }
}
