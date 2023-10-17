using System;
using System.Collections.Generic;
using System.Linq;

namespace Labratory2
{
    public class AlbumList: List<MusicBase> 
    {   
        
        public override string ToString()
        {
            string result="\n";
            foreach (var track in this)
            {
                result +=(this.IndexOf(track)+1)+". "+ track.Name+"\n";
            }

            return result;

        }
        public string SortAlbumList()
        {   
            var sortedtrack = from track in this
                orderby track.Name
                select track;
            
            string result="\n";
            foreach (var track in sortedtrack)
            {
                result +=(this.IndexOf(track)+1)+". "+ track.Name+"\n";
            }
            return result;
        }
    }
}