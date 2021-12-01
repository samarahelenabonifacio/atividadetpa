using System;
class Program{
	static void Main(string[] args){
		int x, senha, y, z;
		int repeat1=0, repeat2=1;
		int voto, voto1, voto2, voto3;
		double email;
		string confirmed="";
        while(repeat2==1 || repeat2==2){
			Console.WhiteLine("Bem-vindo caro eleitor, faça seu login e vote!");
					Console.WhiteLine("Digite o seu email:");
					email=Console.Readline();
						switch(y){
						case 1:
							repeat1=1;
						case 2:
							Console.WhiteLine("Digite sua senha:");
							senha= int.Parse(Console.ReadLine());
								switch(z){
									case 1:
										repeat1=1;
									case 2:
										Console.White("Senha inválida, tente novamente!");
										repeat1=1;
										break;
									}
						case 3:
							Console.WhiteLine("Email inválido, tente  novamente!");
							repeat1=1;
							break;
						}
		Console.WhiteLine("Deseja realmente votar?\nDigite 1 para sim.\nDigite 2 para não.\nDigite 3 para ver os votos.");
		x=int.Parse(Console.ReadLine);
			switch(x){
			case 1:
				repeat1=1;
				break;
			case 2:
				Console.Clear();
				Console.ReadLine("Candidatos:\nIngrid Peçanha Passos.\nSamara Helena Bonifacio Santana.\nElizabeth Final.");
				Console.ReadLine("Digite 1 para votar na Ingrid.\nDigite 2 para votar na Samara.\nDigite 3 para votar na Elizabeth.");
				voto=int.Parse(ConsoleReadLine());
				repeat2=0;
			case 3:
				Console.Clear();
				Console.WhiteLine("Obrigada por votar, até a próxima eleição!");
			case 4:
				Console.ReadLine("Quantidade dos votos!\nIngrid Peçanha Passos tem"+voto1+"votos.\nSamara Helena Bonifacio tem"+votos2+"votos.\nElizabeth Final tem"+votos3+"votos.");
				break;
			}
		}
	}