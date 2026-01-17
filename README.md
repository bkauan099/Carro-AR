
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

4. **Localize a aba Project**: No painel inferior do Unity, navegue pela estrutura de pastas dentro de `Assets`.
5. **Acesse as Cenas**: Procure e abra a pasta chamada `Scenes` (Cenas).
6. **Carregue a Cena Inicial**: Dentro desta pasta, localize o arquivo chamado `intro` (ícone da Unity) e dê um duplo clique sobre ele.
7. **Visualize o Conteúdo**: A cena de introdução será carregada. Agora você poderá ver a interface inicial do projeto na aba **Game**, onde é possível testar a seleção de veículos.
<div align="center">
  <p><b>Figura 3</b> - Interface Inicial do Projeto de Realidade Aumentada</p>
  <img width="603" height="313" alt="Captura de tela 2026-01-17 125112" src="https://github.com/user-attachments/assets/2c4fc935-1a3d-4150-bddf-9921bd4b1adb" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>

Para que a Realidade Aumentada funcione corretamente, é necessário garantir que o motor do Vuforia esteja ativo e configurado no projeto:

#### 1. Ativação nas Configurações de XR
Siga este caminho para habilitar o suporte no Android:
* Vá ao menu superior em **Edit > Project Settings**.
* Na lista à esquerda, selecione **Player**.
* Clique no ícone do **Android** (o robô verde) para acessar as configurações de dispositivo móvel.
* Role até a aba **XR Settings** e marque a caixa **Vuforia Augmented Reality Supported**.
* *Atenção:* Se a opção não aparecer, utilize o link "Vuforia Augmented Reality" em "XR Support Installers" para baixar o módulo necessário.

#### 2. Configuração da ARCamera
Substitua a câmera padrão pelos componentes do Vuforia para ativar a RA:
* Na sua **Hierarchy**, verifique se existe o objeto **ARCamera**.
* Caso haja apenas uma *Main Camera* comum, ela deve ser substituída, pois não possui os sensores de rastreamento necessários.
* Para adicionar, clique com o botão direito na Hierarchy e selecione **Vuforia Engine > AR Camera**.

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

#### Escolhendo o seu Carro
* **Navegação**: Utilize as setas laterais (**"<"** e **">"**) para navegar entre os modelos de carros disponíveis no objeto *Garage*.
* **Seleção**: Conforme indicado na interface, clique diretamente sobre o modelo 3D para confirmar a escolha e avançar para o modo de Realidade Aumentada.

####  Ativando a Realidade Aumentada
Para visualizar o veículo através da câmera (Webcam ou Telemóvel), o fluxo funciona da seguinte forma:
1. **Abertura da Câmara**: Ao avançar da cena `intro` para a cena `main`, a Unity ativa a câmara através do motor do **Vuforia Engine**.
2. **Uso de Marcadores**: Aponte a câmara para o **Image Target** (marcador físico) configurado. Quando o sistema reconhecer o alvo, o carro escolhido aparecerá "fixado" sobre ele na tela.
### 4. Geração e Instalação do APK

Para rodar o projeto no seu telemóvel Android, siga estes passos:

1. **Configuração de Build:** No Unity, aceda a `File > Build Settings`, selecione a plataforma **Android** e garanta que as cenas `intro` e `main` estão na lista.
   
2. **Identificação do App:** Em `Player Settings`, defina o *Package Name* (ex: `com.ARTech.ARCasca`) e verifique se o suporte ao **Vuforia** está ativo em *XR Settings*.
 
3. **Gerar Arquivo:** Clique em **Build**, escolha uma pasta na sua máquina e dê um nome ao arquivo (ex: `CarroAR.apk`).
<div align="center">
  <p><b>Figura 6</b> - Processo de Build e Geração do arquivo APK para Android</p>
  <img width="800" height="408" alt="image" src="https://github.com/user-attachments/assets/90fd551a-6869-4075-b000-68d5f84ab5a2" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>
 
  
### 5. Como Usar o Aplicativo

1. **Instalação:** Transfira o arquivo `CarroAR.apk` para o seu dispositivo Android e realize a instalação.
2. **Permissões:** Ao abrir o app **AR-CASCA** pela primeira vez, autorize o acesso à **Câmera** para permitir o rastreamento do ambiente.

<div align="center">
  <p><b>Figura 7</b> - Aplicativo CAR-AR no Android</p>
 <img width="300" height="1280" alt="image (1)" src="https://github.com/user-attachments/assets/87faea15-791b-4378-9e53-04f407c930a5" />
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>

3. **Seleção:** Na tela inicial, utilize  o modelo do veículo e clique sobre ele para iniciar a projeção.
4. **Visualização:** Aponte a câmera para uma superfície plana para ver o carro surgir em 3D integrado ao mundo real.
5. **Instalação:** Transfira o arquivo para o telemóvel, instale e **autorize o acesso à câmara** para que a Realidade Aumentada funcione corretamente.
   
<div align="center">
  <p><b>Figura 8</b> - Aplicativo CAR-AR em execução: Visualização de Realidade Aumentada no Android</p>
 <img width="400" height="595" alt="Captura de tela 2026-01-17 163424" src="https://github.com/user-attachments/assets/dd8243cc-d46f-4014-8722-858f0bd726a3" />
<img width="400" height="611" alt="Captura de tela 2026-01-17 163436" src="https://github.com/user-attachments/assets/7bc96881-1512-4aee-9b08-26258b1e549f" />

  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>
<hr>

<div align="center">
  <h3> 7. Teste Você Mesmo!</h3>
  <p>Escaneie o QR Code abaixo para baixar o APK diretamente no seu Android e testar a Realidade Aumentada agora mesmo.</p>
  
  <img width="493" height="478" alt="image (2)" src="https://github.com/user-attachments/assets/52bbd5ae-894f-4980-a45c-9e535b9eb70f" />
  
  <p><b>Figura 8</b> - QR Code para download do Aplicativo Carro-AR</p>
  <p><i>Fonte: Autoria Própria (2026).</i></p>
</div>

<br>

> **Nota:** Para que a experiência funcione, lembre-se de imprimir ou exibir em outra tela o **Image Target** (Marcador) utilizado no projeto para que a ARCamera possa identificar o ponto de ancoragem do veículo.

###  Tecnologias Utilizadas

O projeto **Carro-AR** foi construído utilizando um ecossistema de ferramentas voltadas para o desenvolvimento de software 3D e experiências imersivas:

* **Engine**: **Unity 2018.4 LTS** (Long Term Support), garantindo a estabilidade necessária para projetos de Realidade Aumentada.
* **Linguagem**: **C# (C Sharp)**, utilizada para o desenvolvimento de todos os scripts de interação, navegação de interface e controle da garagem.
* **Realidade Aumentada (AR)**: **Vuforia Engine**, responsável pelo rastreamento de imagens e projeção dos modelos 3D no ambiente real.

.



