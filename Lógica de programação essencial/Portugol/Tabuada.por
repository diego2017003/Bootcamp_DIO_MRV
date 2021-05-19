programa
{
	
	funcao inicio()
	{
		inteiro acumulador,resultado, numero,termos
		acumulador = 1
		escreva("Digite o número que deseja ver a tabuada: ")
		leia(numero)
		escreva("Digite a quantidade de termos: ")
		leia(termos)
		faca{
			resultado = numero*acumulador
			escreva(numero+" X " + acumulador+ " = " + resultado+" \n")
			acumulador++
		}enquanto(acumulador<=termos)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 333; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */