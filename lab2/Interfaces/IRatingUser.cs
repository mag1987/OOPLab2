using System.Collections.Generic;

namespace lab2
{
    public interface IRatingUser
    {
        void UserRate(IRateable rateable, IRatingSystem system);
        int UserKarma { get; set; }

        List<IRateable> Recommended { get; set; }
    }
}
