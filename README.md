# Gestão de uma escola

Esta aplicação Windows Forms é projetada para a gestão de uma escola.

## Funcionalidades

### Login Multiusuário
- Login para **Administrador**, **Professor** e **Aluno**.

#### Administrador
- Credenciais de login iniciais são fornecidas em um documento separado para o primeiro acesso.
- Capacidades:
  - Criar/aceitar alterações para:
    - **Anos**: por exemplo, 5º, 6º, 7º, 8º...
    - **Turmas**:
      - Disciplinas:
        - Nome
        - Sigla
        - Número de aulas
    - **Professores**:
      - Nome
      - Morada
      - Contacto
      - Número de Identificação Fiscal (NIF)
      - Disciplinas lecionadas
      - Login/senha
      - Número de funcionário (único)
    - **Alunos**:
      - Nome
      - Morada
      - Contacto
      - Número de Identificação Fiscal (NIF)
      - Login/senha
      - Número de aluno (único)
  - Aprovar ou cancelar pedidos de alteração de dados

#### Professor
- Lançamento de notas nas disciplinas/anos que leciona
- Perfil:
  - Pedido de alteração de dados

#### Aluno
- Visualização das próprias notas
- Perfil:
  - Pedido de alteração de dados
- Movimentos de cartão (depósito)

### Estrutura Escolar
- Cada ano pode ter várias turmas.
- Cada turma tem um número definido de alunos, sem sobreposição permitida.
- Não podem existir alunos ou professores repetidos (validação por NIF).
- Os administradores têm acesso a listagens detalhadas de anos, turmas, disciplinas, professores e alunos.
- Os limites de tamanho da turma devem ser respeitados.

### Configurações Pré-definidas
- Os anos de 5º e 6º são pré-criados, juntamente com 5 disciplinas para cada um desses anos.

### Cartão Escolar
- Criação de um "cartão" para os alunos para depositar saldo.

### Gestão de Sessão
- Opção de "logoff".

### Comunicação
- Sistema de mensagens para interações entre professores e alunos, com notificações para mensagens não lidas.

### Aspectos Técnicos
- Implementação usando Listas, Arrays, Classes, etc.

