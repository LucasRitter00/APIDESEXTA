
import { useState, useEffect } from "react";
import { Card, CardContent } from "@/components/ui/card";
import { Button } from "@/components/ui/button";
import { Home, Users, PlusCircle } from "lucide-react";

export default function App() {
  const [jogadores, setJogadores] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5000/jogadores")
      .then((res) => res.json())
      .then((data) => setJogadores(data))
      .catch((err) => console.error(err));
  }, []);

  return (
    <div className="min-h-screen bg-green-100 text-gray-800">
      <header className="bg-green-700 text-white p-4 shadow-md flex justify-between items-center">
        <h1 className="text-2xl font-bold">Projeto API Futebol</h1>
        <nav className="space-x-4">
          <Button variant="ghost" className="text-white"><Home className="inline-block mr-1" />Início</Button>
          <Button variant="ghost" className="text-white"><Users className="inline-block mr-1" />Jogadores</Button>
          <Button variant="ghost" className="text-white"><PlusCircle className="inline-block mr-1" />Novo</Button>
        </nav>
      </header>

      <main className="p-6 grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
        {jogadores.map((jogador) => (
          <Card key={jogador.id} className="rounded-2xl shadow-md">
            <CardContent className="p-4">
              <h2 className="text-xl font-semibold mb-2">{jogador.nome}</h2>
              <p><strong>Posição:</strong> {jogador.posicao}</p>
              <p><strong>Time:</strong> {jogador.time}</p>
              <p><strong>Camisa:</strong> {jogador.numeroCamisa}</p>
              <p><strong>Nascimento:</strong> {new Date(jogador.dataNascimento).toLocaleDateString()}</p>
              <p><strong>Altura:</strong> {jogador.altura} m</p>
              <p><strong>Peso:</strong> {jogador.peso} kg</p>
            </CardContent>
          </Card>
        ))}
      </main>
    </div>
  );
}
