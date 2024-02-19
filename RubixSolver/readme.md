## Rubix Cube Representation

(Or Rubiks I'm not sure)

This project is not meant to solve Rubix cubes, but a way to create a representation in code and manipulate it's data. 

### Installation

This is a simple C# project created in JetBrains Rider. If you are using VS Code this isn't an issue, you can just use the solution file to open the project.

### Diary

The below reads more of a play-by-play of my thoughts going through this.

I wanted to use a very easy to understand method for this solution. I am not at all familiar with efficient Rubix cube design, nor how one would design a cube with a solver in mind.

Due to this, I have opted to use the simplest design I can think of. We can just have each side as a 3x3 array.

I have come across several papers on Rubix cube design, such as: https://dl.acm.org/doi/10.1145/800058.801107

However, these primarily seem to deal with solving them, not creating one to be used by a human. (Of course I am sure that if I was able to read further I would eat my words, but the recruiter said that I should only spend an hour!)

The rotate method is fairly simple but I'm understanding it better. This is a fantastic way to study how changing data effects things around it in code.