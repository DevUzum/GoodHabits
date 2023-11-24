using GoodHabits.Refatoracao;
using GoodHabits.Dry;

Console.WriteLine("Hello, World!");

#region Refatoracao

//Joquempo joquempo = new Joquempo();

//Console.WriteLine("PLAYER 1 ESCOLHA (1 - PEDRA, 2 - PAPEL, 3 - TESOURA)");
//var player1 = int.Parse(Console.ReadLine());

//Console.WriteLine("PLAYER 2 ESCOLHA (1 - PEDRA, 2 - PAPEL, 3 - TESOURA)");
//var player2 = int.Parse(Console.ReadLine());

//Console.WriteLine(joquempo.JoquempoMethod(player1, player2));

/******************************************************************************/

//JoquempoRefact joquempoRefact = new JoquempoRefact();

//Console.WriteLine("PLAYER 1 ESCOLHA (1 - PEDRA, 2 - PAPEL, 3 - TESOURA)");
//Escolha jogador1 = (Escolha)Enum.Parse(typeof(Escolha), Console.ReadLine());

//Console.WriteLine("PLAYER 2 ESCOLHA (1 - PEDRA, 2 - PAPEL, 3 - TESOURA)");
//Escolha jogador2 = (Escolha)Enum.Parse(typeof(Escolha), Console.ReadLine());

//Console.WriteLine(joquempoRefact.JoquempoMethod(jogador1, jogador2));

#endregion

#region Dry

List<string> cpfs = new List<string>();

cpfs.Add("30555837017");
cpfs.Add("44066144004");

Cliente cliente = new Cliente();

cliente.MascararCpf(cpfs);

/******************************************************************************/

List<string> cpfs2 = new List<string>();

cpfs2.Add("30555837017");
cpfs2.Add("44066144004");

ClienteVip clienteVip = new ClienteVip();

clienteVip.MascararCpf(cpfs2);

#endregion


