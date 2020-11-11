using System.Collections.Generic;
using System.Linq;

/************************************************************************************
 * 
 *							        Leaderboard Manager
 *							  
 *				                  Leaderboard Data Script
 *				     Handles Leaderboard Data & Leaderboard Store Classes
 *			
 *			                        Script written by: 
 *			           Jonathan Carter (https://jonathan.carter.games)
 *			        
 *									Version: 1.0.2
 *						   Last Updated: 07/10/2020 (d/m/y)					
 * 
*************************************************************************************/

namespace CarterGames.Assets.LeaderboardManager
{
    /// <summary>
    /// (CLASS) Class that holds the data used on in the local leaderboard system.
    /// </summary>
    [System.Serializable]
    public class LeaderboardData
    {
        /// <summary>
        /// The players name
        /// </summary>
        public string playerName;

        /// <summary>
        /// The players score
        /// </summary>
        public float playerScore;

        /// <summary>
        /// Blank constructor for the leaderboarddata class
        /// </summary>
        public LeaderboardData() { }

        /// <summary>
        /// Constructor that inputs the name and score vales for you
        /// </summary>
        /// <param name="name">name to input</param>
        /// <param name="score">score to input</param>
        public LeaderboardData(string name, float score)
        {
            playerName = name;
            playerScore = score;
        }
    }


    /// <summary>
    /// (CLASS) Class that holds a list of leaderboard data class so it can be sorted 'n' all
    /// </summary>
    [System.Serializable]
    public class LeaderboardStore
    {
        /// <summary>
        /// A list of the leaderboarddata 
        /// </summary>
        public List<LeaderboardData> leaderboardData;

        /// <summary>
        /// Constructor, creates a new list of leaderboarddata
        /// </summary>
        public LeaderboardStore()
        {
            leaderboardData = new List<LeaderboardData>();
        }

        /// <summary>
        /// IOrderedEnumerable... Sorts the leaderboard data by player score
        /// </summary>
        public IOrderedEnumerable<LeaderboardData> SortedLBD
        {
            get 
            {
                return leaderboardData.OrderBy(m => m.playerScore);
            }
        }
    }
}