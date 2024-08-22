import { ButtonIconEdit } from '../Button/Button';
import '../Input/Style.css'

import pencil from '../../assets/icons/VectorIconeBranco.svg'

import cancel from '../../assets/icons/Vector.svg'

export const InputList = ({ cor, corBorda, check, texto, onChange }) => {
    return (
        <section style={{ backgroundColor: cor }} className="inputPurple">

            <div className='duo2'>
                <input onChange={onChange} className='check' type='checkbox' checked={check} />

                <p className='text'>{texto}</p>
            </div>

            <div className='duo'>
                <ButtonIconEdit style={{borderColor: corBorda}} icone={cancel} />
                <ButtonIconEdit style={{backgroundColor: corBorda}} icone={pencil} />
            </div>

        </section>
    );
}