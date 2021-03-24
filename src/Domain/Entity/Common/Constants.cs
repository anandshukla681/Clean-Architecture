using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Common
{
    public  enum Role
    {
        SuperAdmin,
        Admin,
        User
    }


    enum DefectStatus
    {
        UATOpen,
        UATReOpen,
        UATClosed,
        STOpen,
        STReOpen,
        STClosed,
        DevOpen,
        DevClosed
    }
}
