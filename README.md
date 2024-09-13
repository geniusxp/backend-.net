<img src="https://github.com/geniusxp/backend-.net/blob/main/banner_geniusxp.png">

# Sobre o GeniusXP
GeniusXP é uma plataforma centralizada para gestão de eventos que simplifica operações como inscrições, pagamentos e check-in, enquanto aumenta o engajamento com enquetes e networking. A inteligência artificial da GeniusXP utiliza as preferências dos usuários para oferecer uma experiência altamente personalizada e otimizar o planejamento. Com análise de sentimento e assistência virtual, a plataforma proporciona interações mais significativas, elevando a eficiência da gestão e tornando os eventos mais impactantes para cada participante.

# Arquitetura de Software Utilizada
Para a arquitetura da API do projeto GeniusXP, optamos por adotar uma abordagem **monolítica**. Essa decisão é justificada por diversos fatores que levam em conta tanto o contexto atual do projeto quanto seus requisitos técnicos e operacionais.

A abordagem monolítica se destaca pela sua simplicidade inicial. No estágio atual de desenvolvimento da GeniusXP, que foca em eventos menores e está em fase de crescimento e construção de uma base sólida de clientes, é mais eficiente lidar com uma única base de código. Essa estrutura permite um desenvolvimento mais rápido e menos complexo, uma vez que todos os componentes — desde a interface de usuário até a lógica de negócios e a camada de dados — estão agrupados e organizados em uma única aplicação. Isso reduz a necessidade de gerenciar múltiplos serviços ou lidar com a comunicação entre eles, algo que seria necessário em uma arquitetura de microsserviços.

A complexidade adicional trazida por microsserviços, como a necessidade de orquestrar a comunicação entre serviços, gerenciar transações distribuídas e implementar sistemas de monitoramento avançados, pode não ser justificável nesta fase inicial do projeto. Um sistema monolítico, por outro lado, tem uma implementação mais simples e direta, facilitando o desenvolvimento, testes e depuração.

Embora a arquitetura monolítica possa, em alguns casos, oferecer limitações de escalabilidade, essas limitações só se tornam relevantes conforme o projeto cresce substancialmente. Nesse momento inicial, os eventos menores que a GeniusXP está organizando e gerenciando não exigem a escalabilidade granular e distribuída de uma arquitetura de microsserviços. Quando a base de clientes e a complexidade das operações crescerem, podemos considerar uma migração para microsserviços, mas isso será feito de maneira gradual e estratégica, conforme a demanda exigir.

# Arquitetura da Solução

# Design Pattern Aplicado

Na implementação da API do projeto GeniusXP, decidimos utilizar o padrão de criação Builder. O padrão Builder é eficaz quando se deseja fornecer uma maneira flexível e controlada de construir objetos complexos, separando a criação de um objeto da sua representação final.

O uso do Builder traz benefícios claros:

- **Facilita a manutenção:** O código se torna mais modular e organizado, permitindo a criação de instâncias de classes de forma fluida e flexível.
- **Controle sobre a construção de objetos complexos:** Com o Builder, é possível gerenciar a criação de objetos que possuem diversos atributos opcionais ou diferentes configurações sem comprometer a clareza do código.
- **Encapsulamento de lógica complexa:** Ele permite que a complexidade da construção do objeto seja ocultada dentro do builder, deixando o código principal mais limpo e de fácil entendimento.

Assim, o padrão Builder foi implementado para otimizar a construção das classes da API, promovendo maior flexibilidade e manutenção eficiente.

# Instruções para executar o projeto

# Equipe GeniusXP
- RM99565 - Erick Nathan Capito Pereira
- RM550841 - Lucas Araujo Oliveira Silva
- RM99409 - Michael José Bernardi Da Silva
- RM99577 - Guilherme Dias Gomes
