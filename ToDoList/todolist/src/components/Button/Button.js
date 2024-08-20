import '../Button/Style.css' 
import fotoBranca from '../../assets/icons/VectorIconeBranco.svg'

import foto from '../../assets/icons/mingcute_pencil-fill.svg'
export const ButtonNew = () => {
    return(
        	<button className='button-purple'>
                <p className='text'>Nova tarefa</p>
            </button>
    );
}

export const ButtonIconCancel = () => {
    return(
        <button className='cancel'>
            <img className= 'lapisPreto' src={fotoBranca} alt=""/>
        </button>
    );
}
export const ButtonIconEdit = ({icone}) => {
    return(
        <button className='edit'>
            <img className= 'lapis' src={icone} alt=""/>
        </button>
    );
}