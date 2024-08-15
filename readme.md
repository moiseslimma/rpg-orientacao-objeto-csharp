# RPG Hero Project

Este é um projeto simples de RPG em C# que implementa uma hierarquia de classes para diferentes tipos de heróis, como Magos, Cavaleiros, Ninjas e mais. Cada herói possui atributos como Nome, Pontos de Vida (HP), Pontos de Magia (MP), Nível e Tipo de Herói. O projeto demonstra a utilização de herança, encapsulamento e polimorfismo.

## Estrutura do Projeto

- **Hero (Classe Abstrata)**: Classe base que define os atributos e métodos comuns a todos os heróis.
  - **Atributos**: `Name`, `Hp`, `Mp`, `Level`, `HeroType`
  - **Métodos**:
    - `ToString()`: Retorna uma string com informações sobre o herói.
    - `Attack()`: Método virtual que representa um ataque genérico.
    - `HowMuchHp(int level)`: Método estático que define os pontos de vida com base no nível.
    - `HowMuchMp(int level)`: Método estático que define os pontos de magia com base no nível.

- **BlackWizard (Classe Derivada)**: Classe que herda de `Hero` e representa um mago negro.
- **Knight (Classe Derivada)**: Classe que herda de `Hero` e representa um cavaleiro.
- **Wizard (Classe Derivada)**: Classe que herda de `Hero` e representa um mago.
  - **Métodos**:
    - `Attack()`: Sobrescreve o método de ataque para lançar magia.
    - `Attack(int Bonus)`: Sobrecarga do método de ataque com bônus.