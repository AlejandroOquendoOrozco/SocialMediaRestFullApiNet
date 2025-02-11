﻿using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities;

public partial class Publicacion:BaseEntity
{
   

    public int IdUsuario { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Imagen { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; } = new List<Comentario>();

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
