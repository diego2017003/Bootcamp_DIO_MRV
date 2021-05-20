programa
{
	
	funcao inicio()
	{
		cadeia nomes[] = { "andre","thiago","bruno","cassio"}
		real alturas[] = {1.71,1.78,1.75,1.81}
		cadeia tabela[4][2]
		escreva("------------\n")
		escreva("   Tabela   \n")
		escreva("------------\n")
		para(inteiro i = 0;i<4;i++){
			tabela[i][0] = nomes[i]
			tabela[i][1] = ""+alturas[i]+""
		}
		para(inteiro i = 0;i<4;i++){
			escreva(tabela[i][0]+"  "+tabela[i][1]+"\n") 
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 238; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */