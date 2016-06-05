using System;

namespace BlockRacer.Mvc.Models {
    public class Event {
        public enum Type { gameStarted, playerLeft, playerMovement, gameOver }
        
        private DateTime date { get; set; }
        
        private Player player { get; set; }
        
        
    }
}