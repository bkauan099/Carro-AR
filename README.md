**Guia de Instalação e Execução: Carro-AR**
		Este guia detalha o passo a passo para configurar o ambiente de desenvolvimento e rodar o projeto de Realidade Aumentada no seu dispositivo móvel.
Para o funcionamento do software será necessário fazer algumas instalações. 

**Pré-requisitos**: 

Antes de começar, certifique-se de ter instalado:
**Unity Hub**: Gerenciador de versões da Unity.
**Unity Editor 2018.4 LTS**: Versão estável recomendada para este projeto.
**Módulo Android Build Support**: Incluindo SDK, NDK e OpenJDK (essencial para gerar o app para celular).
VS Code: Editor leve para visualização de código.
1. **Preparação do Ambiente**
Antes de baixar os arquivos, você precisa das ferramentas certas:
**Unity Hub**: Baixe e instale o Unity Hub. Ele é o gerenciador de versões da Unity.
Editor da Unity: Dentro do Unity Hub, na aba "Installs", instale uma versão estável (recomendo a 2018.4 LTS, que costumam ser compatíveis com esse projetos).Ao instalar, marque o módulo Android Build Support, para rodar no celular.
Figura 1 - Editor Unity 2018.4.17f1 configurado com suporte para build Android.
  <img width="476" height="128" alt="Captura de tela 2026-01-17 112155" src="https://github.com/user-attachments/assets/147ab983-99f8-49df-86a7-39152d406368" />
Fonte: Autoria Própria.
2.** Baixando o Projeto**

Vá até a página do repositório: bkauan099/Carro-AR.
Clique no botão verde "Code".
Escolha "Download ZIP" e extraia a pasta no seu computador.
3. Abrindo o Projeto no Unity Hub
Na janela do Unity Hub:
Clique no botão Add (ao lado de "New project").
Navegue até na pasta extraída do seu computador.
Procure pela pasta onde você extraiu o arquivo. O caminho deve ser parecido com este Carro-AR-main.
Importante: Você deve selecionar a pasta que contém as subpastas Assets, Library e ProjectSettings. Se selecionar uma pasta "vazia", o Unity não reconhecerá o projeto.
Figura 2 - Arquivo do Projeto Adicionado ao Unity.
<img width="506" height="149" alt="Captura de tela 2026-01-17 125032" src="https://github.com/user-attachments/assets/70cd1549-3b5b-4bd7-943a-929e81746746" />

Fonte: Autoria Própria.
Após a conclusão do download e a abertura do projeto no Unity, siga os passos abaixo para visualizar o conteúdo corretamente:
Localize a aba Project: No painel inferior do Unity, navegue pela estrutura de pastas dentro de Assets.
Acesse as Cenas: Procure e abra a pasta chamada Scenes (Cenas).
Carregue a Cena Inicial: Dentro desta pasta, localize o arquivo chamado intro (ícone do Unity) e dê um duplo clique sobre ele.
Visualize o Conteúdo: A cena de introdução será carregada. Agora você poderá ver a interface inicial do projeto na aba Game.
Figura 3 - Interface Inicial do Projeto de Realidade Aumentada.
<img width="603" height="313" alt="Captura de tela 2026-01-17 125112" src="https://github.com/user-attachments/assets/2c4fc935-1a3d-4150-bddf-9921bd4b1adb" />

Fonte: Autoria Própria.
Para que a Realidade Aumentada funcione no modo Play dentro do Unity Editor, você precisa garantir que o motor do Vuforia esteja ativo e configurado corretamente. Como você está usando a versão 2018.4.17f1, o processo é feito pelas configurações do Player.
Aqui está o passo a passo para instalar e ativar:
1. Ativação nas Configurações de XR
Você deve seguir este caminho:
Vá ao menu superior em Edit > Project Settings.
Na lista à esquerda, selecione Player.
Clique no ícone do Android (o robozinho verde) para ver as configurações do celular.
Role até encontrar a aba XR Settings.
Marque a caixa Vuforia Augmented Reality Supported.
Atenção: Se essa opção não aparecer, clique no link azul "Vuforia Augmented Reality" sob o título "XR Support Installers" para baixar o instalador necessário.
2. Configuração da ARCamera
Após ativar o suporte, você precisa que a sua cena utilize os componentes do Vuforia em vez de uma câmera comum:
Na sua Hierarchy, verifique se existe um objeto chamado ARCamera.
Se houver apenas uma Main Camera comum, ela não ativará a realidade aumentada.
Para adicionar a câmera correta, clique com o botão direito na Hierarchy e vá em Vuforia Engine > AR Camera.
Figura 4 - Configuração para ativar o Vuforia.
<img width="434" height="374" alt="Captura de tela 2026-01-17 125200" src="https://github.com/user-attachments/assets/06cafd23-49a2-4fc2-8278-0a9d5dccc564" />
Fonte: Autoria Própria.

Figura 5 - Interação com a Realidade Aumentada.
<img width="605" height="289" alt="Captura de tela 2026-01-17 125250" src="https://github.com/user-attachments/assets/9f9901c3-93ea-4d43-ad61-8671dff08150" />

Fonte: Autoria Própria.

Na Figura 5 demonstra  como você pode interagir com o projeto:
Escolhendo o seu Carro
		Na tela atual, você pode clicar nas setas laterais ("<" e ">") para navegar entre os diferentes modelos de carros disponíveis no seu objeto Garage.
		Como diz a mensagem na tela: "Clique no Carro para Começar". Ao clicar no modelo 3D, o sistema selecionará esse veículo para a visualização em AR.
Ativando a Realidade Aumentada via Câmera
		Para ver o carro através da sua câmera (webcam), o fluxo do projeto geralmente funciona assim:
Abertura da Câmera: Ao avançar da tela de introdução (intro) para a cena principal (main), a Unity tentará ativar a sua webcam através do motor do Vuforia.
Uso de Marcadores: Aponte a sua webcam para o Image Target (o marcador físico ou imagem) que você configurou. Se o Vuforia reconhecer a imagem, o carro que você escolheu aparecerá "fixado" sobre ela na tela do computador.


Tecnologias Utilizadas
Engine: Unity 2022.3.x
Linguagem: C# (C Sharp)
AR: ARFoundation ou Vuforia (conforme pacotes instalados).



