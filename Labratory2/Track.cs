using System;

namespace Labratory2
{
    public class Track: MusicBase
    {
      
        public Track(string name, double durability, bool isRemix)
        {
            Name = name;
            Durability = durability;
            IsRemix = isRemix;
        }
       public override string ToString()
        {
            string result;
            if (IsRemix==false){ 
                result =($"{Name} - {Durability}");
                return result;
            }
            else
            { 
                result = ($"{Name}(Remix) - {Durability}");
                return result;
            }
        }
       
    }
    
    
}