import axios from "axios";
import { ref } from 'vue'

const weaponService = (function(){

    const weapons = ref([]);

    const weaponControllerUrl = "https://localhost:7203/weapon";

    ( async ()=>{
        const request = await axios.get(weaponControllerUrl);
        weapons.value = request.data;
    })()

    const getAllWeapons = () => weapons;

    const getById = async (weaponId) => {
        const request = await axios.get(`https://localhost:7203/weapon/${weaponId}`)
        return request.data;
    }

    const putWeapon = async (editedWeapon) => {
        await axios.put("https://localhost:7203/weapon", editedWeapon)
        
        const temporaryWeaponArray = JSON.parse( JSON.stringify( weapons.value ))

        const index = temporaryWeaponArray.findIndex( weapon => parseInt( weapon.id ) === parseInt( editedWeapon.id ) );

        weapons.value[index].weaponName = editedWeapon.weaponName;
        weapons.value[index].weaponCost = editedWeapon.weaponCost;
        weapons.value[index].inUse = editedWeapon.inUse;

    }

    const postWeapon = ( newWeapon ) => {
        axios.post( weaponControllerUrl, newWeapon )
        weapons.value.push(newWeapon);
    }

    const deleteWeapon = async ( weaponToDelete ) => {
        await axios.delete(`https://localhost:7203/weapon/${weaponToDelete}`)
        
    }

    return {
        getAllWeapons,
        getById,
        deleteWeapon,
        postWeapon,
        putWeapon
    }
}())

export default weaponService;