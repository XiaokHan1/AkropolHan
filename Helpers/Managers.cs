//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Akropol.Helpers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Managers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdRoles { get; set; }
        public int IdFond { get; set; }
    
        public virtual Fond Fond { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
