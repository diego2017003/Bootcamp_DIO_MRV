programa
{
	
	funcao inicio()
	{
		//declarando as notas que compoem a media
		real nota1,nota2,nota3,nota4,media
		//nome do usuario
		cadeia nome
		//recebendo as informações do usuario para a média
		escreva("Digite seu nome: ")
		leia(nome)
		escreva("Digite a nota 1: ")
		leia(nota1)
		escreva("Digite a nota 2: ")
		leia(nota2)
		escreva("Digite a nota 3: ")
		leia(nota3)
		escreva("Digite a nota 4: ")
		leia(nota4)
		//calculo da media
		media = (nota1+nota2+nota3+nota4)/4
		//exibindo a media
		escreva("A sua média é: "+media+"\n")
		//verificando o status do aluno com essa média
		se(media>=7.0){//aprovado por media
			escreva("Parabéns você foi aprovado")	
		}
		se(media<7 e media>=5.0){//foi para recuperação
			escreva("você foi pra recuperação"+"\n")
			real notaRecuperacao
			escreva("informe a nota da recuperação: ")
			leia(notaRecuperacao)
			media = (media+notaRecuperacao)/2      //media com a recuperação
			se(media>=7){
				escreva("Parabéns "+nome+" ,Você foi aprovado com média "+media)
			}
			senao{
				escreva(nome+" ,Você foi reprovado com média "+media)
			}
		}
		senao{//Reprovado sem recuperação devido nota muito baixa
			escreva(nome+" ,Você foi reprovado com a média "+media)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1167; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */