Ola,

Esta api foi criada para testar meus conhecimentos. Nela foi linkado o ngrok para realizar testes via IPKISS.

Foi feita uma controller principal chamada ValuesController que visa captar os dados do balance e event, a controller acessa 2 services as quais contem as regras de negocios. Não foi feita a repository por ser uma api simples sem conexão ao banco de dados.

Na service do balance é realizada uma verificação se existe a conta informada.
Na service do event é realizada verificações de qual o tipo de transação sera feita sendo esses tipos deposito, saque e transferencia.

Foi implementado injeção de dependencia e foi implementado a interface para que a controller não olhe diretamente para a service.

O projeto foi configurado para rodar em ambiente de desenvolvimento na porta 5000 e foi configurado para rodar em ambiente de iis express na porta 44315.
