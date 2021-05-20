programa
{
	inclua biblioteca Util --> u
	funcao inicio()
	{
		const inteiro TAMANHO = 10//definido a constante do tamanho da matriz
		inteiro matriz[TAMANHO][TAMANHO]//definindo a matriz
		para(inteiro linha=0;linha<TAMANHO;linha++){//percorrendo as linhas
			para(inteiro coluna=0;coluna<TAMANHO;coluna++){//percorrendo as colunas
				matriz[linha][coluna] = u.sorteia(1,100)//preenchendo a amtriz com valores aleatorios
				escreva("|"+matriz[linha][coluna]+"|")//escrevendo a matriz, todos os elementos da mesma linha			
			}
			escreva("\n")//iniciando visualmente uma nova linha
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 589; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */