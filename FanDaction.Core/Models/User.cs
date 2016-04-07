using FanDaction.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Core.Models
{
    public class User : BaseModel
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }
        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public decimal Balance { get; set; }

        public int TotalPts { get; set; }

        public int PtsWeek { get; set; }

        public int PtsLastWeek { get; set; }

        public int PtsDay { get; set; }

        public int PtsMonth { get; set; }

        public DateTime? DateCreated { get; set; }

        public string Password { get; set; }

        public int FreeBalance { get; set; }

        public DateTime? LastLogin { get; set; }

        public string Username { get; set; }

        public DateTime? DOB { get; set; }

        public bool Football { get; set; }

        public bool Baseball { get; set; }

        public bool Basketball { get; set; }

        public bool Hockey { get; set; }

        public bool Golf { get; set; }

        public bool Soccer { get; set; }

        public bool Rugby { get; set; }
        
        public bool Cricket { get; set; }

        public bool SendNewsLetter { get; set; }

        public bool SendPromotions { get; set; }

        public bool SendResults { get; set; }

        public bool SendOrderPlaced { get; set; }

        public bool SendCompetition { get; set; }

        public string Phone { get; set; }

        public string LikesOther { get; set; }

        public int TotalFreeBalance { get; set; }

        public bool NoEmails { get; set; }

        public bool SendOnDeposits { get; set; }

        public int NumDeposits { get; set; }

        public string Referall { get; set; }

        public string AboutMe { get; set; }

        public string FavoriteTeams { get; set; }

        public string TwitterAccount { get; set; }

        public string FacebookAccount { get; set; }

        public int GamesWon { get; set; }

        public int FriendsOnSite { get; set; }

        public int LifetimFantaStock { get; set; }

        public int ProfileViews { get; set; }

        public string FavoritePlayers { get; set; }

        public string LeastFavoriteTeams { get; set; }

        public string LastFavoritePlayers { get; set; }

        public bool Enabled { get; set; }

        public string Comment { get; set; }

        public DateTime? CommentDate { get; set; }

        public bool IsLogged { get; set; }

        public string IPAddress { get; set; }
    }
}
