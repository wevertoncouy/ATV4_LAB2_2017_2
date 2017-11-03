using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppPB_Lab2_2017_2.Models
{
    public class ConfiguracaoIngresso : EntityTypeConfiguration<Ingresso>
    {
        public ConfiguracaoIngresso()
        {
            //Configura associação ane-to-many (Um -pra muitos)

            
                             HasMany(se => se.Sessoes)
                            .WithOptional(i => i.Ingresso)//Associação opcional(Fraca)
                            .HasForeignKey(i => i.IngressoId)
                            .WillCascadeOnDelete(false);
        }
    }
}