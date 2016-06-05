using System;
using System.Collections.Generic;

namespace BlockRacer.Mvc.Models {
    public class RaceResult {
        Player creator;
        
        Guid raceGuid;
        
        List<PlayerResult> result;
        
    }
    
    class PlayerResult {
        int nrOfTurns;
        
        int position;
        
        Player player;
    }
}