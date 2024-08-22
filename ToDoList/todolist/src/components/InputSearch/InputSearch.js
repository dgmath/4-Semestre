import search from '../../assets/icons/material-symbols_searchPesquisa.svg'
import '../InputSearch/Style.css'
export const InputSearch = ({value}) => {
    return (
        <div className='pesquisa'>
            <img className='icon' src={search}/>
            <input
                className='inp'
                placeholder="Procurar tarefa"
                value={value}
            />
        </div>
    );
}