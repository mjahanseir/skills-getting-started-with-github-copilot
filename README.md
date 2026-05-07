# Getting Started with GitHub Copilot

<img src="https://octodex.github.com/images/Professortocat_v2.png" align="right" height="200px" />

Hey mjahanseir!

Mona here. I'm done preparing your exercise. Hope you enjoy! 💚

Remember, it's self-paced so feel free to take a break! ☕️

[![](https://img.shields.io/badge/Go%20to%20Exercise-%E2%86%92-1f883d?style=for-the-badge&logo=github&labelColor=197935)](https://github.com/mjahanseir/skills-getting-started-with-github-copilot/issues/1)

---

&copy; 2025 GitHub &bull; [Code of Conduct](https://www.contributor-covenant.org/version/2/1/code_of_conduct/code_of_conduct.md) &bull; [MIT License](https://gh.io/mit)

## Container and Azure Deployment

### Run locally in Docker

1. Install Docker Desktop.
2. Build the image:
   ```bash
   docker build -t mergington-high-school .
   ```
3. Run the container:
   ```bash
   docker run -p 8000:8000 mergington-high-school
   ```
4. Open http://localhost:8000

### Push image to Azure Container Registry

1. Install Azure CLI.
2. Login to Azure:
   ```bash
   az login
   ```
3. Create an ACR instance:
   ```bash
   az acr create --resource-group your-resource-group --name youracrname --sku Basic
   ```
4. Build and push the image to ACR:
   ```bash
   az acr login --name youracrname
   docker build -t youracrname.azurecr.io/mergington-high-school:latest .
   docker push youracrname.azurecr.io/mergington-high-school:latest
   ```

### GitHub Actions CI/CD

A workflow is defined in `.github/workflows/deploy.yml` to:
- install Python dependencies
- run tests
- build and push the Docker image to Azure Container Registry
- deploy to Azure Container Instances on pushes to `main`

Update the workflow with your Azure values:
- `youracrname`
- `your-resource-group`
- `eastus` (or your preferred region)

Set the repository secret `AZURE_CREDENTIALS` with your Azure service principal JSON.

