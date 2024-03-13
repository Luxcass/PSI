## Modelo Relacional

Um modelo relacional é um modelo de dados para sistemas de gerenciamento de banco de dados (SGBDs) que organiza os dados em tabelas bidimensionais (também conhecidas como relações). Essas tabelas são compostas por linhas e colunas, onde cada linha representa uma entrada de dados e cada coluna representa um atributo ou campo específico.

O modelo relacional foi proposto inicialmente por Edgar F. Codd, um cientista da computação, em um artigo seminal publicado em 1970. Ele propôs que os dados deveriam ser organizados de forma a refletir a estrutura lógica dos dados, em oposição à estrutura física, como era comum em modelos anteriores.

O modelo relacional é amplamente utilizado em sistemas de banco de dados comerciais e é a base para a maioria dos SGBDs relacionais modernos, como MySQL, PostgreSQL, Oracle, SQL Server, entre outros. Ele fornece uma estrutura flexível e poderosa para armazenar e manipular dados, facilitando o desenvolvimento e manutenção de sistemas de informação.

**Tabelas (relações):** Os dados são organizados em tabelas, onde cada tabela tem um nome único e é composta por linhas e colunas.

**Chaves primárias e estrangeiras:** As chaves primárias são atributos que identificam exclusivamente cada linha em uma tabela. As chaves estrangeiras são atributos que estabelecem relações entre duas tabelas.

**Integridade referencial:** O modelo relacional garante a integridade referencial, o que significa que as relações entre tabelas são mantidas corretamente, garantindo consistência e precisão dos dados.

**Operações relacionais:** O modelo relacional fornece um conjunto de operações para manipular dados, como seleção, projeção, união, interseção e diferença, entre outras.

**Normalização:** O processo de normalização é utilizado para organizar os dados de forma eficiente, reduzindo redundância e evitando anomalias de inserção, atualização e exclusão.

## Modelo Hierárquico

Um modelo hierárquico é um tipo de modelo de dados em que os dados são organizados em uma estrutura hierárquica semelhante a uma árvore. Neste modelo, os dados são representados por meio de entidades que estão conectadas em uma hierarquia, onde cada entidade (ou nó) pode ter um ou mais relacionamentos pai-filho.

O modelo hierárquico foi popularizado principalmente pela IBM na década de 1960, com o sistema de gerenciamento de banco de dados Hierarchical Data System (IMS). Esse modelo foi amplamente utilizado em sistemas de bancos de dados durante as décadas de 1960 e 1970, especialmente em aplicações como sistemas de informação gerenciais e sistemas de processamento de transações.

No entanto, o modelo hierárquico possui algumas limitações, como dificuldades na representação de relações muitos-para-muitos e complexidade na manipulação de dados. Com o tempo, modelos mais flexíveis, como o modelo relacional, ganharam popularidade e se tornaram dominantes nos sistemas de gerenciamento de banco de dados.

**Entidades:** As entidades são representadas como nós na hierarquia. Cada nó pode ter zero ou mais nós filhos, mas apenas um nó pai, exceto o nó raiz, que não possui pai.

**Relacionamentos pai-filho:** Os relacionamentos entre entidades são estabelecidos por meio de ligações pai-filho. Isso significa que cada nó filho está associado a um nó pai.

**Nó raiz:** O nó superior na hierarquia é chamado de nó raiz. Ele não tem um pai e serve como ponto de partida para acessar os dados na hierarquia.

**Nós intermediários:** Os nós intermediários são aqueles que têm pelo menos um nó filho e um nó pai.

**Nós folha:** Os nós folha são os nós que não têm filhos. Eles são os elementos finais da hierarquia.

## Modelo de Rede 

O modelo de rede é um modelo de dados utilizado em sistemas de gerenciamento de banco de dados (SGBDs) que permite representar relações complexas entre os dados de uma forma mais flexível do que o modelo hierárquico, mas menos flexível do que o modelo relacional. Esse modelo foi desenvolvido para superar algumas limitações do modelo hierárquico, especialmente em relação à representação de relações muitos-para-muitos.

O modelo de rede foi introduzido na década de 1960 e foi amplamente utilizado em sistemas de banco de dados durante as décadas de 1960 e 1970. Um dos SGBDs mais conhecidos que implementava esse modelo era o CODASYL DBTG (Committee on Data Systems and Languages Database Task Group).

No entanto, o modelo de rede perdeu popularidade com o tempo devido à sua complexidade de implementação e à ascensão do modelo relacional, que oferecia uma abordagem mais simples e flexível para modelar dados. Hoje em dia, o modelo relacional é predominante na maioria dos sistemas de gerenciamento de banco de dados, embora o modelo de rede ainda possa ser encontrado em alguns sistemas legados e em contextos específicos onde suas características são vantajosas.

**Entidades e Relacionamentos:** Os dados são organizados em dois tipos principais de estruturas: entidades e relacionamentos. As entidades são semelhantes às entidades do modelo hierárquico, representando registros individuais de dados. Os relacionamentos, por outro lado, são estruturas que definem as conexões entre as entidades.

**Nós e Conjuntos:** Os nós no modelo de rede podem representar entidades ou relacionamentos. Cada nó possui um conjunto de propriedades (ou campos) que descrevem os dados associados a ele.

**Conexões e Associações:** As conexões no modelo de rede são usadas para estabelecer associações entre os nós. Uma conexão é uma relação direcional entre dois nós, indicando uma associação entre eles. Essas conexões podem ser usadas para representar relações muitos-para-muitos, permitindo que uma entidade esteja relacionada a várias outras entidades.

**Esquemas de rede:** Assim como no modelo hierárquico, o modelo de rede também utiliza esquemas para definir a estrutura dos dados. Os esquemas de rede incluem definições de tipos de entidades, relacionamentos e atributos, bem como informações sobre as conexões entre eles.