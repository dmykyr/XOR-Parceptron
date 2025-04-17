# XOR Perceptron
## Overview
This project implements a neural network solution for solving the XOR problem with both 2 inputs and 4 inputs. It was developed as part of the Neural Network Systems course assignment.
## Problem Description
The XOR operation is a classical problem in neural networks because it is not linearly separable, making it impossible to solve with a single-layer perceptron. This project demonstrates how to solve this problem using a multi-layer approach.

2-input XOR: The output is 1 if exactly one input is 1, otherwise the output is 0. <br>
4-input XOR: The output is 1 if an odd number of inputs are 1, otherwise the output is 0.

## Implementation Details
### Architecture

- Neuron: The basic building block that takes inputs, applies weights, and produces an output based on a threshold activation function.
- XORPerceptron: A network of three neurons that can learn and solve the 2-input XOR problem.
- FourXORPerceptron: A hierarchical network that uses three XORPerceptron instances to solve the 4-input XOR problem:
  - First XORPerceptron: Handles XOR(x1, x2)
  - Second XORPerceptron: Handles XOR(x3, x4)
  - Third XORPerceptron: Combines the results with XOR(result1, result2)

## Requirements
- .NET 9.0 or higher
- C# development environment
