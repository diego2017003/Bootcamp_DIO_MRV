programa
{
	
	funcao inicio()
	{
		cadeia frutas[4] = {"Maça","Pera","Uva","Jaca"}
		cadeia cesta[][] = {{frutas[0],"100"},{frutas[1],"200"},{frutas[2],"900"},{frutas[3],"89"}}
		inteiro contador = 0
		inteiro tam = 4
		faca{
			escreva(frutas[contador]+"\n")
			contador++	
		}enquanto(contador<tam)
		contador = 0
		faca{
			escreva(cesta[contador][0]+" Possui "+cesta[contador][1]+" unidades \n")
			contador++	
		}enquanto(contador<tam)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 178; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */