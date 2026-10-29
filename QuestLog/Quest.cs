using System;
using System.Collections.Generic;
using System.Text;

namespace QuestLog
{
    public class Quest
    {
        public required string Title { get; set; }
        public required string Giver {  get; set; }
        public int Reward { get; set; }
    }
}
