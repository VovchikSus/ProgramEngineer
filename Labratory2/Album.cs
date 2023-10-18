using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labratory2
{
    public class AlbumList: List<MusicBase> 
    {   
        
        public override string ToString()
        {
            StringBuilder result=new StringBuilder("\n");
            foreach (var track in this)
            {
                result.Append((this.IndexOf(track)+1)+". "+ track.Name+"\n");
            }
            
            return Convert.ToString(result);

        }
        public string SortAlbumList()
        {   
            var sortedtrack = from track in this
                orderby track.Name
                select track;
            
            StringBuilder result=new StringBuilder("\n");
            foreach (var track in sortedtrack)
            {
                result.Append( (this.IndexOf(track)+1)+". "+ track.Name+"\n");
            }
            return Convert.ToString(result);
        }
    }
}