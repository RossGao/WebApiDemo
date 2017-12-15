// Declarative //
pipeline {
	agent any
	
	stages {
		stage('Build') {
			steps {
				bat 'make'
			}
		}
	}
}

// Script //
	node {
		stage('Build') {
			bat 'make'
		}
	}