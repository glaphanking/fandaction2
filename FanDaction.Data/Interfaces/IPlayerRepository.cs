using FanDaction.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanDaction.Data.Interfaces
{
    public interface IPlayerRepository
    {
        void AddPlayer(Player player);

        void DeletePlayer(int id);
    }
}
