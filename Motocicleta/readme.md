# Objetivo 
O objetivo desta avaliação é mensurar a capacidade lógica, conhecimentos sobre OO e
design patterns.

## Tecnologias que deverão ser empregadas
O projeto deverá ser escrito em .Net Core e deverá ser criado um aplicativo em modo
console. A criação dos menus ficam a cargo do candidato.

# Problema
Criar um algoritmo que simule uma motocicleta, onde seja possível acelerar, frear e realizar
a troca de marchas (0 - neutro, 1 – primeira, 2 – segunda, etc).

# Premissas
O mecanismo de velocidade deve estar atrelado às marchas. O sistema deverá incrementar
(5 em 5) a velocidade sempre que a moto for acelerada, caso seja reduzida a velocidade
(frear) ela deverá ser decrementada (8 em 8).

## Cada marcha tem uma velocidade compatível conforme listagem abaixo:
● 1a — 00 até 20 km/h
● 2a — 21 até 40 km/h
● 3a — 41 até 60 km/h
● 4a — 61 até 80 km/h
● 5a — 81 até 100 km/h

## Observações:
● A moto deve ser iniciada com a marcha no neutro.
● Caso a velocidade seja 0, só será possível acelerar se a moto estiver na marcha 1.
● Caso a velocidade extrapole o valor máximo da marcha, ela não poderá ser
aumentada até que seja incrementada a marcha, possibilitando assim o aumento
da velocidade.
● Redução de marcha:
o É possível trocar apenas uma marcha, caso a velocidade seja superior ao
intervalo da marcha anterior.
o Caso a velocidade seja interior ao intervalo da marcha, será possível trocar
normalmente.
Exemplo:
§ Velocidade: 50 – Marcha: 3 -> Será possível reduzir somente até a marcha 2.
§ Velocidade: 10 – Marcha: 5 -> Será possível ir reduzindo até a marcha 1.
● Caso a motocicleta esteja com uma marcha superior a compatível com a
velocidade e o usuário acelerar, o valor da aceleração deve ser decrementado (2
em 2) ao invés de incrementado.
● A velocidade não pode ser negativa.
● Separe as responsabilidades (regras de negócio e interface com o usuário).

## Refatoração
Implemente a classe carro que deverá possuir as mesmas características da motocicleta,
entretanto deverá possuir a marcha ré. Sua velocidade deverá chegar no máximo ao valor
da primeira marcha.

## Método de avaliação
A forma de organização do projeto fica a cargo do candidato, pois a mesma também faz
parte avaliação, bem como a estrutura lógica desenvolvida, comentários, absorção sobre o
escopo apresentado.

## Forma de entrega
O código-fonte desenvolvido deverá ser entregue em formato zip e enviado ao recrutador
responsável pelo contato (Remove as pastas bin e obj, para que o seja possível anexar no
email em formato zip).