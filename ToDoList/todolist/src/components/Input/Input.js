import { ButtonIconEdit } from '../Button/Button';
import '../Input/Style.css'

import pencil from '../../assets/icons/VectorIconeBranco.svg'

import cancel from '../../assets/icons/Vector.svg'

export const InputList = () => {
    return (
        <section className="inputPurple">

            <input className='check' type='checkbox'/>

            <p className='text'>Começar a execução do projeto</p>

            <div className='duo'>
                <ButtonIconEdit icone={cancel} />
                <ButtonIconEdit icone={pencil} />
            </div>

        </section>
    );
}