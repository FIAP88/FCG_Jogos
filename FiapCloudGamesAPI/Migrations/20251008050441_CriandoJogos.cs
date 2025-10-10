using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FCG_API_Jogos.Migrations
{
    /// <inheritdoc />
    public partial class CriandoJogos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Jogo");

            migrationBuilder.UpdateData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Descricao", "IdCategoria", "Nome", "NumeroVendas", "Preco", "Tamanho" },
                values: new object[] { "Explore galáxias e descubra novos planetas.", 2L, "Aventura Cósmica", 543, 129, 45m });

            migrationBuilder.InsertData(
                table: "Jogo",
                columns: new[] { "Id", "Ativo", "AtualizadoPor", "CriadoPor", "DataAtualizacao", "DataCriacao", "Descricao", "IdCategoria", "IdFornecedor", "IdadeMinima", "Nome", "NumeroVendas", "Preco", "Tamanho" },
                values: new object[,]
                {
                    { 2L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sobreviva em uma cidade infestada e resgate sobreviventes.", 24L, 1L, 16, "Cidade Zumbi", 274, 89, 32m },
                    { 3L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equipe-se e lute na arena por fama e prêmios.", 13L, 1L, 12, "Heróis da Arena", 612, 59, 12m },
                    { 4L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistas malucas com drift e saltos impossíveis.", 7L, 1L, 0, "Corrida Extrema", 810, 99, 8m },
                    { 5L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolva enigmas e descubra segredos familiares.", 16L, 1L, 10, "Mistério na Mansão", 132, 49, 5m },
                    { 6L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RPG tático com decisões que mudam o mundo.", 3L, 1L, 14, "Reino das Sombras", 455, 199, 60m },
                    { 7L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerencie sua fazenda, cultive e venda colheitas.", 32L, 1L, 0, "Fazenda Feliz", 298, 39, 3m },
                    { 8L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modo arcade de tiro com muitos desafios e skins.", 9L, 1L, 12, "Tiro ao Alvo", 220, 29, 2m },
                    { 9L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Infiltre-se em corporações e roube segredos.", 26L, 1L, 16, "Espionagem Urbana", 387, 149, 20m },
                    { 10L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Combine peças antigas para desvendar relíquias.", 8L, 1L, 0, "Puzzle das Relíquias", 95, 25, 1m },
                    { 11L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crie cidades, gerencie recursos e expanda seu vale.", 22L, 1L, 0, "Construtores do Vale", 509, 179, 40m },
                    { 12L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore cavernas geradas proceduralmente e morra tentando.", 17L, 1L, 14, "Roguelike das Profundezas", 411, 69, 18m },
                    { 13L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Último sobrevivente ganha — jogue solo ou em esquadrões.", 18L, 1L, 16, "Batalha Real: Ilhas", 922, 139, 35m },
                    { 14L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colete cartas e duel com jogadores ao redor do mundo.", 20L, 1L, 12, "Mestres do Cartão", 201, 79, 4m },
                    { 15L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Narrativa interativa com finais múltiplos.", 21L, 1L, 12, "Contos Visuais", 164, 59, 6m },
                    { 16L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Construa e destrua numa cidade sandbox sem limites.", 22L, 1L, 10, "Sandbox Urbano", 338, 249, 70m },
                    { 17L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore mapas conectados e desbloqueie habilidades.", 23L, 1L, 14, "Metroidvania Sombria", 476, 119, 27m },
                    { 18L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colete, construa abrigo e enfrente perigos naturais.", 24L, 1L, 16, "Sobrevivência na Ilha", 633, 109, 22m },
                    { 19L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aventure-se em um mundo vasto com histórias locais.", 25L, 1L, 16, "Mundo Aberto: Lendas", 712, 279, 95m },
                    { 20L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Invada sistemas e manipule o ciberespaço.", 26L, 1L, 16, "Hackers do Futuro", 253, 139, 10m },
                    { 21L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missões de stealth com IA reativa e rotas alternativas.", 27L, 1L, 18, "Operação Furtiva", 489, 129, 14m },
                    { 22L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Histórias entrelaçadas com personagens memoráveis.", 28L, 1L, 12, "Narrativas Cruzadas", 142, 69, 9m },
                    { 23L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Equipe até 4 jogadores para explorar templos antigos.", 29L, 1L, 10, "Co-op das Ruínas", 378, 149, 25m },
                    { 24L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experiência imersiva VR com missões curtas.", 30L, 1L, 12, "Realidade Virtual: Estação", 87, 119, 12m },
                    { 25L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Use realidade aumentada para encontrar tesouros locais.", 31L, 1L, 0, "AR Caça ao Tesouro", 210, 49, 1m },
                    { 26L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogo educativo que ensina lógica e algoritmos.", 32L, 1L, 0, "Aprenda Programando", 76, 29, 2m },
                    { 27L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rotinas gamificadas para exercícios diários.", 33L, 1L, 0, "Treino Fitness Pro", 324, 39, 1m },
                    { 28L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogo musical com fases e desafios rítmicos.", 34L, 1L, 0, "Ritmo da Cidade", 198, 59, 6m },
                    { 29L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minigames para jogar com a galera em sofá-coop.", 35L, 1L, 0, "Festa dos Amigos", 401, 69, 5m },
                    { 30L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teste seus conhecimentos gerais com perguntas do país.", 36L, 1L, 0, "Trivia Nacional", 58, 19, 1m },
                    { 31L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Construção de deck com combos e sinergias profundas.", 37L, 1L, 12, "Cartas e Estratégia", 321, 89, 7m },
                    { 32L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clássicos de tabuleiro com regras adaptadas para digital.", 38L, 1L, 0, "Tabuleiro Digital", 143, 49, 3m },
                    { 33L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navegue entre ilhas e complete missões locais.", 2L, 1L, 10, "Aventura Isleña", 265, 109, 24m },
                    { 34L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sobreviva no gelo e gerencie calor, comida e companhia.", 24L, 1L, 16, "Expedição Polar", 487, 159, 28m },
                    { 35L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velocidade e pixel art em pistas nostálgicas.", 7L, 1L, 0, "Corrida Retro", 199, 29, 2m },
                    { 36L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Combates 1vs1 com golpes especiais e progressão.", 10L, 1L, 14, "Lutas de Rua", 554, 79, 9m },
                    { 37L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salte, corra e colete em fases desafiadoras.", 11L, 1L, 0, "Plataformas Clássicas", 286, 39, 4m },
                    { 38L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atmosfera tensa e sustos baseados em som e luz.", 12L, 1L, 18, "Terror Noturno", 673, 99, 11m },
                    { 39L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experiência curta e contemplativa com arte singular.", 14L, 1L, 0, "Indie Poético", 121, 29, 2m },
                    { 40L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clique e evolua sua máquina para gerar recursos.", 15L, 1L, 0, "Casual Clicker", 204, 19, 1m },
                    { 41L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diálogos e puzzles em estilo clássico.", 16L, 1L, 12, "Aventura Gráfica Retro", 88, 39, 3m },
                    { 42L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada corrida é única — morra e tente de novo.", 17L, 1L, 14, "Labirinto Roguelike", 349, 79, 16m },
                    { 43L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Partidas rápidas com itens e power-ups aleatórios.", 18L, 1L, 12, "Caos Royale", 900, 109, 30m },
                    { 44L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Times competem por objetivos e controle de mapa.", 19L, 1L, 12, "Moba Estratégico", 734, 199, 28m },
                    { 45L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Táticas profundas em rounds intensos de cartas.", 20L, 1L, 12, "Duelo de Baralhos", 276, 69, 6m },
                    { 46L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escolhas e relacionamentos com múltiplos finais.", 21L, 1L, 12, "Romance Visual", 153, 49, 2m },
                    { 47L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ferramentas para construir mundos e compartilhar.", 22L, 1L, 0, "Criativo Sandbox", 420, 289, 85m },
                    { 48L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Progressão por habilidades e segredos escondidos.", 23L, 1L, 14, "Metroidvania Retro", 357, 99, 21m },
                    { 49L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sobreviva à fauna hostil e ao clima extremo.", 24L, 1L, 16, "Apocalipse Selvagem", 611, 169, 33m },
                    { 50L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Missões secundárias e histórias emergentes.", 25L, 1L, 12, "Mundos Abertos: Explorar", 702, 239, 90m },
                    { 51L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Construa sua nação no meio do deserto e enfrente inimigos poderosos.", 13L, 1L, 12, "Império das Areias", 730, 140, 37m },
                    { 52L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Investigue crimes misteriosos em uma cidade sem lei.", 14L, 1L, 16, "Sombras da Noite", 801, 165, 42m },
                    { 53L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore ruínas antigas em busca de segredos esquecidos.", 15L, 1L, 12, "Horizonte Perdido", 589, 130, 33m },
                    { 54L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pilote naves e derrote piratas espaciais.", 16L, 1L, 14, "Caçador Estelar", 955, 185, 51m },
                    { 55L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enfrente uma guerra em meio a erupções e tempestades de cinzas.", 17L, 1L, 18, "Tempestade de Fogo", 900, 200, 58m },
                    { 56L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desvende os segredos escondidos entre paredes de vidro mágico.", 18L, 1L, 10, "Labirinto de Cristal", 476, 110, 25m },
                    { 57L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sobreviva em um mundo tomado por criaturas mutantes.", 19L, 1L, 16, "Planeta do Caos", 841, 210, 54m },
                    { 58L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comande guerreiros mecanizados em batalhas épicas.", 20L, 1L, 14, "Cavaleiros de Aço", 967, 190, 49m },
                    { 59L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escolha seu lado e determine o destino do mundo.", 21L, 1L, 12, "Luz e Trevas", 832, 160, 38m },
                    { 60L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Construa uma base na Lua e enfrente perigos espaciais.", 22L, 1L, 10, "Expedição Lunar", 749, 175, 46m },
                    { 61L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Persiga criminosos em um mundo dominado pelo caos.", 23L, 1L, 16, "Caçada Implacável", 713, 145, 29m },
                    { 62L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proteja seu castelo das forças invasoras do norte.", 24L, 1L, 12, "Fortaleza de Gelo", 691, 155, 41m },
                    { 63L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lidere tropas e conquiste territórios em guerras globais.", 25L, 1L, 18, "Campos de Batalha", 989, 210, 53m },
                    { 64L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mergulhe nas profundezas e descubra criaturas exóticas.", 26L, 1L, 8, "Aventura Subaquática", 517, 120, 28m },
                    { 65L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore uma metrópole governada por robôs conscientes.", 27L, 1L, 14, "Cidade das Máquinas", 864, 195, 48m },
                    { 66L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proteja os últimos sobreviventes da humanidade.", 28L, 1L, 12, "Refúgio da Aurora", 620, 165, 36m },
                    { 67L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reconstrua uma civilização em um planeta distante.", 29L, 1L, 14, "Colônia Perdida", 708, 180, 40m },
                    { 68L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descubra criaturas mágicas e salve o coração da floresta.", 30L, 1L, 8, "Floresta Encantada", 532, 125, 27m },
                    { 69L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sobreviva em um mundo em chamas após a queda dos deuses.", 31L, 1L, 18, "Céu Vermelho", 976, 220, 52m },
                    { 70L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enfrente campeões de outros planetas em combates épicos.", 32L, 1L, 16, "Arena Galáctica", 871, 185, 47m },
                    { 71L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suba ao topo da montanha e enfrente seus medos.", 33L, 1L, 12, "Montanha Proibida", 654, 140, 35m },
                    { 72L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unifique clãs e domine terras selvagens.", 34L, 1L, 14, "Guerra das Tribos", 820, 160, 43m },
                    { 73L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Defenda o portal sagrado contra hordas de inimigos.", 35L, 1L, 16, "O Último Guardião", 904, 175, 44m },
                    { 74L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore ruínas e desvenda uma história esquecida.", 36L, 1L, 10, "Cidade Fantasma", 611, 135, 31m },
                    { 75L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Controle os elementos e proteja o equilíbrio do mundo.", 37L, 1L, 14, "Guardiões da Tempestade", 950, 200, 50m },
                    { 76L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lute até o fim em um campo de guerra em constante mudança.", 38L, 1L, 16, "Batalha Real", 985, 180, 46m },
                    { 77L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descubra a cidade lendária escondida sob as dunas.", 1L, 1L, 12, "Oasis Perdido", 576, 120, 30m },
                    { 78L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enfrente demônios e restaure a luz do reino.", 2L, 1L, 16, "Legião Sombria", 794, 150, 39m },
                    { 79L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Junte-se a heróis lendários em combates incríveis.", 3L, 1L, 10, "Super Batalha", 664, 130, 27m },
                    { 80L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Participe da corrida mais perigosa do universo.", 4L, 1L, 12, "Corrida Cósmica", 881, 160, 35m },
                    { 81L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navegue pelos mares e descubra criaturas míticas.", 5L, 1L, 8, "Lendas do Mar", 745, 150, 40m },
                    { 82L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Controle o poder dos ventos para salvar o mundo.", 6L, 1L, 10, "Heróis do Vento", 625, 135, 32m },
                    { 83L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experimente uma simulação que redefine a realidade.", 7L, 1L, 18, "Projeto Infinito", 988, 220, 56m },
                    { 84L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Treine guerreiros e salve o reino da destruição.", 8L, 1L, 12, "Caminho dos Heróis", 657, 145, 34m },
                    { 85L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reescreva a história e altere o futuro.", 9L, 1L, 14, "Ecos do Passado", 720, 155, 37m },
                    { 86L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pilote naves entre tempestades de gelo.", 10L, 1L, 16, "Céu Congelado", 894, 175, 44m },
                    { 87L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Participe de operações táticas de elite.", 11L, 1L, 16, "Força Delta", 945, 165, 41m },
                    { 88L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A humanidade enfrenta sua própria criação.", 12L, 1L, 18, "O Despertar das Máquinas", 974, 210, 50m },
                    { 89L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore um território esquecido por séculos.", 13L, 1L, 10, "Vale das Sombras", 603, 120, 29m },
                    { 90L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Proteja o mundo das forças das trevas eternas.", 14L, 1L, 14, "Guardiões da Luz", 861, 190, 45m },
                    { 91L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sobreviva em um planeta radioativo e hostil.", 15L, 1L, 16, "Planeta Proibido", 917, 220, 54m },
                    { 92L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conquiste o espaço e estabeleça novas colônias.", 16L, 1L, 14, "A Última Fronteira", 931, 200, 47m },
                    { 93L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cace, construa e sobreviva em um mundo inexplorado.", 17L, 1L, 12, "Terra Selvagem", 780, 140, 33m },
                    { 94L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hackeie sistemas e lute contra corporações.", 18L, 1L, 16, "Universo Digital", 858, 160, 38m },
                    { 95L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Restaure o trono perdido e unifique o império.", 19L, 1L, 14, "O Retorno do Rei", 899, 170, 43m },
                    { 96L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domine pistas futuristas em alta velocidade.", 20L, 1L, 10, "Corrida do Amanhã", 706, 150, 36m },
                    { 97L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Viaje até o sol e revele seus mistérios.", 21L, 1L, 12, "Expedição Solar", 824, 185, 48m },
                    { 98L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enfrente entidades antigas e sobreviva à loucura.", 22L, 1L, 18, "O Chamado da Escuridão", 977, 165, 39m },
                    { 99L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Construa máquinas e torne-se um herói lendário.", 23L, 1L, 14, "Lendas de Ferro", 854, 170, 42m },
                    { 100L, true, "", "system", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conclua a jornada que mudará o destino do universo.", 24L, 1L, 16, "Aventura Final", 933, 190, 46m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Jogo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Jogo",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Descricao", "IdCategoria", "Nome", "NumeroVendas", "Preco", "Tags", "Tamanho" },
                values: new object[] { "Game 1 Description", 1L, "Game1", 0, 100, null, 10m });
        }
    }
}
