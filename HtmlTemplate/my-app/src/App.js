import './App.css';
import Carousel from './components/Template/Carousel/Carousel';
import Header from './components/Template/Card/Header/Header';
import Description from './components/Template/Card/Description';
import Navbar from './components/Template/Card/Header/Navbar';

function App() {
  return (
    <div className="App">
      <Header />
      <Navbar />
      <Carousel />
      <Description cardTitle = " Çocuklara Nasıl Davranılmalı ?" />
      <Description cardTitle = "Çocukların Eğitimi ve Ebeveynler"/>
      <Description cardTitle = "Çocuk Psikolojisi" />

      
    </div>
  );
}

export default App;
