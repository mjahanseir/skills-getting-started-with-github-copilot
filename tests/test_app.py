from fastapi.testclient import TestClient
from src.app import app

client = TestClient(app)


def test_root_redirects_to_static_index():
    response = client.get("/")
    assert response.status_code == 307
    assert response.headers["location"] == "/static/index.html"


def test_get_activities_returns_json():
    response = client.get("/activities")
    assert response.status_code == 200
    data = response.json()
    assert "Chess Club" in data
    assert data["Chess Club"]["description"] == "Learn strategies and compete in chess tournaments"
