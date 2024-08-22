import moment from "moment";
import '../Title/Style.css'
export const Title = () => {
    
    // moment().locale('pt-br');
    const mes = moment().format('MMMM');
    const num = moment().format('Do');
    const dia = moment().format('dddd');
    
    
    return(
        <div>
            <h1 className="titulo">
                
                    <span>{dia},</span> <span className="roxo">{num}</span> <span>de{mes}</span> 
                
            </h1>
        </div>
    );
}