﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppPB_Lab2_2017_2.Models.Configurations
{
    public class ConfiguracaoFilme : EntityTypeConfiguration<Filme>
    {
        public ConfiguracaoFilme()
        {
            //COnfigura associção many-to-many Muitos Pra muitos

         
                            HasMany(a => a.Atores)
                            .WithMany(f => f.Filmes)
                            .Map(af =>
                            {
                                af.MapLeftKey("codFilme");
                                af.MapRightKey("codAtor");
                                af.ToTable("FilmeAtor");
                            }
                            );
        }
    }
}