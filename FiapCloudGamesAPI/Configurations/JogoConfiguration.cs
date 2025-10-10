using FCG_API_Jogos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace FCG_API_Jogos.Configurations
{
    public class JogoConfiguration : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
           
            builder.ToTable("Jogo");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("BIGINT").ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(150)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnType("VARCHAR(1000)");
            builder.Property(p => p.Tamanho).HasColumnType("DECIMAL(10,2)");
            builder.Property(p => p.Preco).HasColumnType("INT");
            builder.Property(p => p.Descricao).HasColumnType("VARCHAR(150)");
            builder.Property(p => p.IdCategoria).HasColumnType("BIGINT");
            builder.Property(p => p.IdadeMinima).HasColumnType("INT");
            builder.Property(p => p.Ativo).HasColumnType("BIT").HasDefaultValue(true); ;
            builder.Property(p => p.DataCriacao).HasColumnType("DATETIME2").IsRequired().Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property(p => p.CriadoPor).HasColumnType("VARCHAR(100)").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property(p => p.DataAtualizacao).HasColumnType("DATETIME2");
            builder.Property(p => p.AtualizadoPor).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.IdFornecedor).HasColumnType("BIGINT").IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Jogos)
                .HasForeignKey(p => p.IdCategoria);

            builder.HasOne(p => p.EmpresaFornecedora)
                .WithMany(p => p.Jogos)
                .HasForeignKey(p => p.IdFornecedor);

            builder.HasData(
                new Jogo("Aventura Cósmica", "Explore galáxias e descubra novos planetas.", 45, 129, 2, 10, true, 1, "system") { Id = 1, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 543 },
                new Jogo("Cidade Zumbi", "Sobreviva em uma cidade infestada e resgate sobreviventes.", 32, 89, 24, 16, true, 1, "system") { Id = 2, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 274 },
                new Jogo("Heróis da Arena", "Equipe-se e lute na arena por fama e prêmios.", 12, 59, 13, 12, true, 1, "system") { Id = 3, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 612 },
                new Jogo("Corrida Extrema", "Pistas malucas com drift e saltos impossíveis.", 8, 99, 7, 0, true, 1, "system") { Id = 4, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 810 },
                new Jogo("Mistério na Mansão", "Resolva enigmas e descubra segredos familiares.", 5, 49, 16, 10, true, 1, "system") { Id = 5, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 132 },
                new Jogo("Reino das Sombras", "RPG tático com decisões que mudam o mundo.", 60, 199, 3, 14, true, 1, "system") { Id = 6, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 455 },
                new Jogo("Fazenda Feliz", "Gerencie sua fazenda, cultive e venda colheitas.", 3, 39, 32, 0, true, 1, "system") { Id = 7, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 298 },
                new Jogo("Tiro ao Alvo", "Modo arcade de tiro com muitos desafios e skins.", 2, 29, 9, 12, true, 1, "system") { Id = 8, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 220 },
                new Jogo("Espionagem Urbana", "Infiltre-se em corporações e roube segredos.", 20, 149, 26, 16, true, 1, "system") { Id = 9, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 387 },
                new Jogo("Puzzle das Relíquias", "Combine peças antigas para desvendar relíquias.", 1, 25, 8, 0, true, 1, "system") { Id = 10, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 95 },

                new Jogo("Construtores do Vale", "Crie cidades, gerencie recursos e expanda seu vale.", 40, 179, 22, 0, true, 1, "system") { Id = 11, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 509 },
                new Jogo("Roguelike das Profundezas", "Explore cavernas geradas proceduralmente e morra tentando.", 18, 69, 17, 14, true, 1, "system") { Id = 12, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 411 },
                new Jogo("Batalha Real: Ilhas", "Último sobrevivente ganha — jogue solo ou em esquadrões.", 35, 139, 18, 16, true, 1, "system") { Id = 13, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 922 },
                new Jogo("Mestres do Cartão", "Colete cartas e duel com jogadores ao redor do mundo.", 4, 79, 20, 12, true, 1, "system") { Id = 14, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 201 },
                new Jogo("Contos Visuais", "Narrativa interativa com finais múltiplos.", 6, 59, 21, 12, true, 1, "system") { Id = 15, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 164 },
                new Jogo("Sandbox Urbano", "Construa e destrua numa cidade sandbox sem limites.", 70, 249, 22, 10, true, 1, "system") { Id = 16, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 338 },
                new Jogo("Metroidvania Sombria", "Explore mapas conectados e desbloqueie habilidades.", 27, 119, 23, 14, true, 1, "system") { Id = 17, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 476 },
                new Jogo("Sobrevivência na Ilha", "Colete, construa abrigo e enfrente perigos naturais.", 22, 109, 24, 16, true, 1, "system") { Id = 18, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 633 },
                new Jogo("Mundo Aberto: Lendas", "Aventure-se em um mundo vasto com histórias locais.", 95, 279, 25, 16, true, 1, "system") { Id = 19, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 712 },
                new Jogo("Hackers do Futuro", "Invada sistemas e manipule o ciberespaço.", 10, 139, 26, 16, true, 1, "system") { Id = 20, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 253 },

                new Jogo("Operação Furtiva", "Missões de stealth com IA reativa e rotas alternativas.", 14, 129, 27, 18, true, 1, "system") { Id = 21, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 489 },
                new Jogo("Narrativas Cruzadas", "Histórias entrelaçadas com personagens memoráveis.", 9, 69, 28, 12, true, 1, "system") { Id = 22, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 142 },
                new Jogo("Co-op das Ruínas", "Equipe até 4 jogadores para explorar templos antigos.", 25, 149, 29, 10, true, 1, "system") { Id = 23, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 378 },
                new Jogo("Realidade Virtual: Estação", "Experiência imersiva VR com missões curtas.", 12, 119, 30, 12, true, 1, "system") { Id = 24, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 87 },
                new Jogo("AR Caça ao Tesouro", "Use realidade aumentada para encontrar tesouros locais.", 1, 49, 31, 0, true, 1, "system") { Id = 25, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 210 },
                new Jogo("Aprenda Programando", "Jogo educativo que ensina lógica e algoritmos.", 2, 29, 32, 0, true, 1, "system") { Id = 26, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 76 },
                new Jogo("Treino Fitness Pro", "Rotinas gamificadas para exercícios diários.", 1, 39, 33, 0, true, 1, "system") { Id = 27, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 324 },
                new Jogo("Ritmo da Cidade", "Jogo musical com fases e desafios rítmicos.", 6, 59, 34, 0, true, 1, "system") { Id = 28, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 198 },
                new Jogo("Festa dos Amigos", "Minigames para jogar com a galera em sofá-coop.", 5, 69, 35, 0, true, 1, "system") { Id = 29, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 401 },
                new Jogo("Trivia Nacional", "Teste seus conhecimentos gerais com perguntas do país.", 1, 19, 36, 0, true, 1, "system") { Id = 30, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 58 },

                new Jogo("Cartas e Estratégia", "Construção de deck com combos e sinergias profundas.", 7, 89, 37, 12, true, 1, "system") { Id = 31, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 321 },
                new Jogo("Tabuleiro Digital", "Clássicos de tabuleiro com regras adaptadas para digital.", 3, 49, 38, 0, true, 1, "system") { Id = 32, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 143 },
                new Jogo("Aventura Isleña", "Navegue entre ilhas e complete missões locais.", 24, 109, 2, 10, true, 1, "system") { Id = 33, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 265 },
                new Jogo("Expedição Polar", "Sobreviva no gelo e gerencie calor, comida e companhia.", 28, 159, 24, 16, true, 1, "system") { Id = 34, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 487 },
                new Jogo("Corrida Retro", "Velocidade e pixel art em pistas nostálgicas.", 2, 29, 7, 0, true, 1, "system") { Id = 35, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 199 },
                new Jogo("Lutas de Rua", "Combates 1vs1 com golpes especiais e progressão.", 9, 79, 10, 14, true, 1, "system") { Id = 36, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 554 },
                new Jogo("Plataformas Clássicas", "Salte, corra e colete em fases desafiadoras.", 4, 39, 11, 0, true, 1, "system") { Id = 37, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 286 },
                new Jogo("Terror Noturno", "Atmosfera tensa e sustos baseados em som e luz.", 11, 99, 12, 18, true, 1, "system") { Id = 38, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 673 },
                new Jogo("Indie Poético", "Experiência curta e contemplativa com arte singular.", 2, 29, 14, 0, true, 1, "system") { Id = 39, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 121 },
                new Jogo("Casual Clicker", "Clique e evolua sua máquina para gerar recursos.", 1, 19, 15, 0, true, 1, "system") { Id = 40, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 204 },

                new Jogo("Aventura Gráfica Retro", "Diálogos e puzzles em estilo clássico.", 3, 39, 16, 12, true, 1, "system") { Id = 41, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 88 },
                new Jogo("Labirinto Roguelike", "Cada corrida é única — morra e tente de novo.", 16, 79, 17, 14, true, 1, "system") { Id = 42, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 349 },
                new Jogo("Caos Royale", "Partidas rápidas com itens e power-ups aleatórios.", 30, 109, 18, 12, true, 1, "system") { Id = 43, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 900 },
                new Jogo("Moba Estratégico", "Times competem por objetivos e controle de mapa.", 28, 199, 19, 12, true, 1, "system") { Id = 44, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 734 },
                new Jogo("Duelo de Baralhos", "Táticas profundas em rounds intensos de cartas.", 6, 69, 20, 12, true, 1, "system") { Id = 45, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 276 },
                new Jogo("Romance Visual", "Escolhas e relacionamentos com múltiplos finais.", 2, 49, 21, 12, true, 1, "system") { Id = 46, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 153 },
                new Jogo("Criativo Sandbox", "Ferramentas para construir mundos e compartilhar.", 85, 289, 22, 0, true, 1, "system") { Id = 47, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 420 },
                new Jogo("Metroidvania Retro", "Progressão por habilidades e segredos escondidos.", 21, 99, 23, 14, true, 1, "system") { Id = 48, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 357 },
                new Jogo("Apocalipse Selvagem", "Sobreviva à fauna hostil e ao clima extremo.", 33, 169, 24, 16, true, 1, "system") { Id = 49, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 611 },
                new Jogo("Mundos Abertos: Explorar", "Missões secundárias e histórias emergentes.", 90, 239, 25, 12, true, 1, "system") { Id = 50, DataCriacao = DateTime.Parse("2025-01-01 00:00:00"), NumeroVendas = 702 }
            );
            builder.HasData(
                new Jogo("Império das Areias", "Construa sua nação no meio do deserto e enfrente inimigos poderosos.", 37, 140, 13, 12, true, 1, "system") { Id = 51, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 730 },
                new Jogo("Sombras da Noite", "Investigue crimes misteriosos em uma cidade sem lei.", 42, 165, 14, 16, true, 1, "system") { Id = 52, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 801 },
                new Jogo("Horizonte Perdido", "Explore ruínas antigas em busca de segredos esquecidos.", 33, 130, 15, 12, true, 1, "system") { Id = 53, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 589 },
                new Jogo("Caçador Estelar", "Pilote naves e derrote piratas espaciais.", 51, 185, 16, 14, true, 1, "system") { Id = 54, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 955 },
                new Jogo("Tempestade de Fogo", "Enfrente uma guerra em meio a erupções e tempestades de cinzas.", 58, 200, 17, 18, true, 1, "system") { Id = 55, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 900 },
                new Jogo("Labirinto de Cristal", "Desvende os segredos escondidos entre paredes de vidro mágico.", 25, 110, 18, 10, true, 1, "system") { Id = 56, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 476 },
                new Jogo("Planeta do Caos", "Sobreviva em um mundo tomado por criaturas mutantes.", 54, 210, 19, 16, true, 1, "system") { Id = 57, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 841 },
                new Jogo("Cavaleiros de Aço", "Comande guerreiros mecanizados em batalhas épicas.", 49, 190, 20, 14, true, 1, "system") { Id = 58, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 967 },
                new Jogo("Luz e Trevas", "Escolha seu lado e determine o destino do mundo.", 38, 160, 21, 12, true, 1, "system") { Id = 59, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 832 },
                new Jogo("Expedição Lunar", "Construa uma base na Lua e enfrente perigos espaciais.", 46, 175, 22, 10, true, 1, "system") { Id = 60, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 749 },
                new Jogo("Caçada Implacável", "Persiga criminosos em um mundo dominado pelo caos.", 29, 145, 23, 16, true, 1, "system") { Id = 61, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 713 },
                new Jogo("Fortaleza de Gelo", "Proteja seu castelo das forças invasoras do norte.", 41, 155, 24, 12, true, 1, "system") { Id = 62, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 691 },
                new Jogo("Campos de Batalha", "Lidere tropas e conquiste territórios em guerras globais.", 53, 210, 25, 18, true, 1, "system") { Id = 63, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 989 },
                new Jogo("Aventura Subaquática", "Mergulhe nas profundezas e descubra criaturas exóticas.", 28, 120, 26, 8, true, 1, "system") { Id = 64, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 517 },
                new Jogo("Cidade das Máquinas", "Explore uma metrópole governada por robôs conscientes.", 48, 195, 27, 14, true, 1, "system") { Id = 65, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 864 },
                new Jogo("Refúgio da Aurora", "Proteja os últimos sobreviventes da humanidade.", 36, 165, 28, 12, true, 1, "system") { Id = 66, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 620 },
                new Jogo("Colônia Perdida", "Reconstrua uma civilização em um planeta distante.", 40, 180, 29, 14, true, 1, "system") { Id = 67, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 708 },
                new Jogo("Floresta Encantada", "Descubra criaturas mágicas e salve o coração da floresta.", 27, 125, 30, 8, true, 1, "system") { Id = 68, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 532 },
                new Jogo("Céu Vermelho", "Sobreviva em um mundo em chamas após a queda dos deuses.", 52, 220, 31, 18, true, 1, "system") { Id = 69, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 976 },
                new Jogo("Arena Galáctica", "Enfrente campeões de outros planetas em combates épicos.", 47, 185, 32, 16, true, 1, "system") { Id = 70, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 871 },
                new Jogo("Montanha Proibida", "Suba ao topo da montanha e enfrente seus medos.", 35, 140, 33, 12, true, 1, "system") { Id = 71, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 654 },
                new Jogo("Guerra das Tribos", "Unifique clãs e domine terras selvagens.", 43, 160, 34, 14, true, 1, "system") { Id = 72, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 820 },
                new Jogo("O Último Guardião", "Defenda o portal sagrado contra hordas de inimigos.", 44, 175, 35, 16, true, 1, "system") { Id = 73, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 904 },
                new Jogo("Cidade Fantasma", "Explore ruínas e desvenda uma história esquecida.", 31, 135, 36, 10, true, 1, "system") { Id = 74, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 611 },
                new Jogo("Guardiões da Tempestade", "Controle os elementos e proteja o equilíbrio do mundo.", 50, 200, 37, 14, true, 1, "system") { Id = 75, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 950 },
                new Jogo("Batalha Real", "Lute até o fim em um campo de guerra em constante mudança.", 46, 180, 38, 16, true, 1, "system") { Id = 76, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 985 },
                new Jogo("Oasis Perdido", "Descubra a cidade lendária escondida sob as dunas.", 30, 120, 1, 12, true, 1, "system") { Id = 77, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 576 },
                new Jogo("Legião Sombria", "Enfrente demônios e restaure a luz do reino.", 39, 150, 2, 16, true, 1, "system") { Id = 78, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 794 },
                new Jogo("Super Batalha", "Junte-se a heróis lendários em combates incríveis.", 27, 130, 3, 10, true, 1, "system") { Id = 79, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 664 },
                new Jogo("Corrida Cósmica", "Participe da corrida mais perigosa do universo.", 35, 160, 4, 12, true, 1, "system") { Id = 80, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 881 },
                new Jogo("Lendas do Mar", "Navegue pelos mares e descubra criaturas míticas.", 40, 150, 5, 8, true, 1, "system") { Id = 81, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 745 },
                new Jogo("Heróis do Vento", "Controle o poder dos ventos para salvar o mundo.", 32, 135, 6, 10, true, 1, "system") { Id = 82, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 625 },
                new Jogo("Projeto Infinito", "Experimente uma simulação que redefine a realidade.", 56, 220, 7, 18, true, 1, "system") { Id = 83, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 988 },
                new Jogo("Caminho dos Heróis", "Treine guerreiros e salve o reino da destruição.", 34, 145, 8, 12, true, 1, "system") { Id = 84, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 657 },
                new Jogo("Ecos do Passado", "Reescreva a história e altere o futuro.", 37, 155, 9, 14, true, 1, "system") { Id = 85, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 720 },
                new Jogo("Céu Congelado", "Pilote naves entre tempestades de gelo.", 44, 175, 10, 16, true, 1, "system") { Id = 86, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 894 },
                new Jogo("Força Delta", "Participe de operações táticas de elite.", 41, 165, 11, 16, true, 1, "system") { Id = 87, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 945 },
                new Jogo("O Despertar das Máquinas", "A humanidade enfrenta sua própria criação.", 50, 210, 12, 18, true, 1, "system") { Id = 88, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 974 },
                new Jogo("Vale das Sombras", "Explore um território esquecido por séculos.", 29, 120, 13, 10, true, 1, "system") { Id = 89, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 603 },
                new Jogo("Guardiões da Luz", "Proteja o mundo das forças das trevas eternas.", 45, 190, 14, 14, true, 1, "system") { Id = 90, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 861 },
                new Jogo("Planeta Proibido", "Sobreviva em um planeta radioativo e hostil.", 54, 220, 15, 16, true, 1, "system") { Id = 91, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 917 },
                new Jogo("A Última Fronteira", "Conquiste o espaço e estabeleça novas colônias.", 47, 200, 16, 14, true, 1, "system") { Id = 92, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 931 },
                new Jogo("Terra Selvagem", "Cace, construa e sobreviva em um mundo inexplorado.", 33, 140, 17, 12, true, 1, "system") { Id = 93, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 780 },
                new Jogo("Universo Digital", "Hackeie sistemas e lute contra corporações.", 38, 160, 18, 16, true, 1, "system") { Id = 94, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 858 },
                new Jogo("O Retorno do Rei", "Restaure o trono perdido e unifique o império.", 43, 170, 19, 14, true, 1, "system") { Id = 95, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 899 },
                new Jogo("Corrida do Amanhã", "Domine pistas futuristas em alta velocidade.", 36, 150, 20, 10, true, 1, "system") { Id = 96, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 706 },
                new Jogo("Expedição Solar", "Viaje até o sol e revele seus mistérios.", 48, 185, 21, 12, true, 1, "system") { Id = 97, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 824 },
                new Jogo("O Chamado da Escuridão", "Enfrente entidades antigas e sobreviva à loucura.", 39, 165, 22, 18, true, 1, "system") { Id = 98, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 977 },
                new Jogo("Lendas de Ferro", "Construa máquinas e torne-se um herói lendário.", 42, 170, 23, 14, true, 1, "system") { Id = 99, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 854 },
                new Jogo("Aventura Final", "Conclua a jornada que mudará o destino do universo.", 46, 190, 24, 16, true, 1, "system") { Id = 100, DataCriacao = DateTime.Parse("2025-01-01"), NumeroVendas = 933 }
            );


        }
    }
}
