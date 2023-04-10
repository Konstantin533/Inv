using System.ComponentModel;
using System.Threading;

namespace Invent.Models
{
    public class InventViewModel
    {
        public int Table { get; set; }
        public int TableStock { get; set; } = 10;
        public int Chair { get;set; } 
        public int ChairStock { get; set; } = 20;
        public int Closet { get;set; } 
        public int ClosetStock { get; set; } = 10;
        public int Sofa { get;set; } 
        public int SofaStock { get; set; } = 7;
        public InventViewModel() { }
        
    }
}