using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppPB_Lab2_2017_2.Models.Configurations
{
    public class ConfiguracaoSala : EntityTypeConfiguration<Sala>
    {
        public ConfiguracaoSala()
        {

            // Configura a propriedade 
            Property(s => s.Descricao)
              .HasColumnType("varchar")
              .IsRequired() //é Obrigatorio
              .HasMaxLength(500); //  Tamanhos Maximo 500 caracteres

            //Configura associçao one-to one
            
                HasOptional(l => l.Localizacao)
                .WithRequired(s => s.Sala)
                .WillCascadeOnDelete(true);

            //Configura associação ane to- many(Um -pra muitos

                           HasMany(se => se.Sessoes)
                            .WithRequired(s => s.Sala)// Associação obrigatoria(Forte)
                            .HasForeignKey(s => s.SalaId)
                            .WillCascadeOnDelete(false);
        }
    }
}