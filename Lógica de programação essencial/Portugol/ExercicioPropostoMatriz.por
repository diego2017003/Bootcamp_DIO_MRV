programa
{
	
	funcao inicio()
	{
		//definimos uma tabela de 3 colunas com a informação de 3 pessoas 
		cadeia tabela[][] = {{"João","São Paulo","(11)9999-5241"},{"Maria","Ribeirão Preto","(16)9999-8596"},{"Ana","Manaus","(92)9999-8574"}}
		inteiro contador = 0,contador2 = 0 //o contador irá andar nas linhas e o contador2 irá percorrer as colunas
		escreva("----------------------------------------\n")
		faca{//esse irá percorrer as linhas
			contador2 = 0
			faca{
				escreva(tabela[contador][contador2]+"|")
				contador2++
			}enquanto(contador2<3)
			escreva("\n")
			contador++
		}enquanto(contador<3)
		escreva("----------------------------------------")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 516; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */