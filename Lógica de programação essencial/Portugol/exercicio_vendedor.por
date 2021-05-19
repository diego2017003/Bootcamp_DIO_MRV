programa
{
	
	funcao inicio()
	{
		real janeiro,fevereiro,marco,abril,total,media
		cadeia nome
		escreva("Digite o nome do vendedor:")
		leia(nome)
		escreva("Digite as vendas de janeiro:")
		leia(janeiro)
		escreva("Digite as vendas de fevereiro:")
		leia(fevereiro)
		escreva("Digite as vendas de março:")
		leia(marco)
		escreva("Digite as vendas de abril:")
		leia(abril)
		total = janeiro+fevereiro+marco+abril
		media = total/4
		escreva("O total de vendas do vendedor "+ nome+" nos ultimos 4 meses, foi "+ total)
		escreva("portanto a média por mês foi: "+media)

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 576; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */