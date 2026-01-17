
#  Carro-AR: Manual de Instalação e Configuração

Este guia detalha o passo a passo para configurar o ambiente de desenvolvimento e rodar o projeto de Realidade Aumentada no seu dispositivo móvel. Para o funcionamento do software, será necessário realizar as seguintes instalações:

###  Pré-requisitos

Antes de começar, certifique-se de ter instalado os seguintes componentes:

* **Unity Hub**: Gerenciador essencial de versões e projetos da Unity.
* **Unity Editor 2018.4 LTS**: Versão estável utilizada para garantir a compatibilidade dos modelos e scripts.
* **Módulo Android Build Support**: Incluindo SDK, NDK e OpenJDK para permitir a exportação para dispositivos móveis.
* **VS Code**: Editor de texto recomendado para visualização e edição leve dos scripts C#.
### 1. Preparação do Ambiente

Antes de baixar os arquivos, é necessário configurar as ferramentas de desenvolvimento:

* **Unity Hub**: Realize o download e a instalação para gerenciar as diferentes versões da engine.
* **Editor da Unity**: Dentro do Unity Hub, na aba **"Installs"**, instale uma versão estável. Recomenda-se a **2018.4 LTS** para garantir a compatibilidade com este projeto.
* **Módulo Android**: No momento da instalação, é fundamental marcar o módulo **Android Build Support** para permitir que o aplicativo seja executado em dispositivos móveis.

<div align="center">
  <p><b>Figura 1</b> - Configuração do Ambiente de Desenvolvimento (Unity e Android SDK)</p>
  <img width="500" height="128" alt="Captura de tela 2026-01-17 112155" src="https://github.com/user-attachments/assets/147ab983-99f8-49df-86a7-39152d406368" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>
### 2. Baixando o Projeto

Para obter os arquivos necessários, siga estas etapas no GitHub:

1. Vá até a página do repositório: [bkauan099/Carro-AR](https://github.com/bkauan099/Carro-AR).
2. Clique no botão verde **"Code"**.
3. Escolha a opção **"Download ZIP"** e extraia o conteúdo da pasta no seu computador.

### 3. Abrindo o Projeto no Unity Hub

Após extrair os arquivos, integre o projeto à engine:

1. Na janela do **Unity Hub**, clique no botão **Add** (ao lado de "New project").
2. Navegue até a pasta onde você extraiu os arquivos. O caminho deve ser similar a `Carro-AR-main`.
3. **Importante:** Selecione a pasta raiz que contém as subpastas `Assets`, `Packages` e `ProjectSettings`. Caso selecione uma pasta incorreta, a Unity não reconhecerá o projeto como válido.

<div align="center">
  <p><b>Figura 2</b> - Arquivo do Projeto Adicionado ao Unity</p>
  <img width="506" height="149" alt="Captura de tela 2026-01-17 125032" src="https://github.com/user-attachments/assets/70cd1549-3b5b-4bd7-943a-929e81746746" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>
Após a conclusão do download e a abertura do projeto no Unity, siga os passos abaixo para visualizar o conteúdo corretamente:

**Localize a aba Project**: No painel inferior do Unity, navegue pela estrutura de pastas dentro de Assets.

**Acesse as Cenas**: Procure e abra a pasta chamada Scenes (Cenas).

**Carregue a Cena Inicial**: Dentro desta pasta, localize o arquivo chamado intro (ícone do Unity) e dê um duplo clique sobre ele.

**Visualize o Conteúdo**: A cena de introdução será carregada. Agora você poderá ver a interface inicial do projeto na aba Game.
<div align="center">
  <p><b>Figura 3</b> - Interface Inicial do Projeto de Realidade Aumentada</p>
  <img width="603" height="313" alt="Captura de tela 2026-01-17 125112" src="https://github.com/user-attachments/assets/2c4fc935-1a3d-4150-bddf-9921bd4b1adb" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>
Para que a Realidade Aumentada funcione no modo Play dentro do Unity Editor, você precisa garantir que o motor do Vuforia esteja ativo e configurado corretamente. Como você está usando 
a versão 2018.4.17f1, o processo é feito pelas configurações do Player.

Aqui está o passo a passo para instalar e ativar:

**1. Ativação nas Configurações de XR**
   
Você deve seguir este caminho:

Vá ao menu superior em Edit > Project Settings.

Na lista à esquerda, selecione Player.

Clique no ícone do Android (o robozinho verde) para ver as configurações do celular.

Role até encontrar a aba XR Settings.

Marque a caixa Vuforia Augmented Reality Supported.

**Atenção**: Se essa opção não aparecer, clique no link azul "Vuforia Augmented Reality" sob o título "XR Support Installers" para baixar o instalador necessário.

**2. Configuração de ARCamera**

Após ativar o suporte, você precisa que a sua cena utilize os componentes do Vuforia em vez de uma câmera comum:

Na sua Hierarchy, verifique se existe um objeto chamado ARCamera.

Se houver apenas uma Main Camera comum, ela não ativará a realidade aumentada.

Para adicionar a câmera correta, clique com o botão direito na Hierarchy e vá em Vuforia Engine > AR Camera.
<div align="center">
  <p><b>Figura 4</b> - Configuração para ativar o Vuforia</p>
  <img width="434" height="374" alt="Captura de tela 2026-01-17 125200" src="https://github.com/user-attachments/assets/06cafd23-49a2-4fc2-8278-0a9d5dccc564" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>
<div align="center">
  <p><b>Figura 5</b> - Interação com a Realidade Aumentada</p>
 <img width="605" height="289" alt="Captura de tela 2026-01-17 125250" src="https://github.com/user-attachments/assets/9f9901c3-93ea-4d43-ad61-8671dff08150" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>

Na Figura 5 demonstra  como você pode interagir com o projeto:

**Escolhendo o seu Carro**

		Na tela atual, você pode clicar nas setas laterais ("<" e ">") para navegar entre os diferentes modelos de carros disponíveis no seu objeto Garage.
		
		Como diz a mensagem na tela: "Clique no Carro para Começar". Ao clicar no modelo 3D, o sistema selecionará esse veículo para a visualização em AR.
		
**Ativando a Realidade Aumentada via Câmera**
		Para ver o carro através da sua câmera (webcam), o fluxo do projeto geralmente funciona assim:
		
**Abertura da Câmera**: Ao avançar da tela de introdução (intro) para a cena principal (main), a Unity tentará ativar a sua webcam através do motor do Vuforia.

**Uso de Marcadores**: Aponte a sua webcam para o Image Target (o marcador físico ou imagem) que você configurou. Se o Vuforia reconhecer a imagem, o carro que você escolheu aparecerá "fixado" sobre ela na tela do computador.
### 4. Geração e Instalação do APK

Para rodar o projeto no seu telemóvel Android, siga estes passos:

1. **Configuração de Build:** No Unity, aceda a `File > Build Settings`, selecione a plataforma **Android** e garanta que as cenas `intro` e `main` estão na lista.
   
2. **Identificação do App:** Em `Player Settings`, defina o *Package Name* (ex: `com.ARTech.ARCasca`) e verifique se o suporte ao **Vuforia** está ativo em *XR Settings*.
 
3. **Gerar Arquivo:** Clique em **Build**, escolha uma pasta na sua máquina e dê um nome ao arquivo (ex: `CarroAR.apk`).
<div align="center">
  <p><b>Figura 6</b> - Processo de Build e Geração do arquivo APK para Android</p>
  <img width="1160" height="608" alt="image" src="https://github.com/user-attachments/assets/90fd551a-6869-4075-b000-68d5f84ab5a2" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>
 
  
### 5. Como Usar o Aplicativo

1. **Instalação:** Transfira o arquivo `CarroAR.apk` para o seu dispositivo Android e realize a instalação.
2. **Permissões:** Ao abrir o app **AR-CASCA** pela primeira vez, autorize o acesso à **Câmera** para permitir o rastreamento do ambiente.
3. **Seleção:** Na tela inicial, utilize  o modelo do veículo e clique sobre ele para iniciar a projeção.
4. **Visualização:** Aponte a câmera para uma superfície plana para ver o carro surgir em 3D integrado ao mundo real.
4. **Instalação:** Transfira o arquivo para o telemóvel, instale e **autorize o acesso à câmara** para que a Realidade Aumentada funcione corretamente.
<div align="center">
  <p><b>Figura 7</b> - Aplicativo CAR-AR em execução: Visualização de Realidade Aumentada no Android</p>
 <img width="576" height="1280" alt="image (1)" src="https://github.com/user-attachments/assets/87faea15-791b-4378-9e53-04f407c930a5" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>

**Tecnologias Utilizadas**

**Engine**: Unity 2018.3.x

**Linguagem**: C# (C Sharp)

**AR**: ARFoundation ou Vuforia (conforme pacotes instalados).



