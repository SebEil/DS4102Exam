<template>
    <section> <h2 class="spacingTop">Weapon Editing</h2>
    <section id="inputSection">
        <section class="container-lg">
            <section class="row justify-content-center">
                <section class="col-lg-3">
                    <form>
                        <section class="input-group">
                            <label for="id" class="form-label">Id</label>
                            <input v-model="weaponId" type="text" class="form-control" id="id" placeholder="Type in ID and press 'Get'"/>
                            <input @click="getWeapon" type="button" value="Get" class="btn btn-primary">
                        </section>
                        
                        <section class="input-group">
                            <label for="name" class="form-label">WeaponName</label>
                            <input v-model="weaponName" type="text" class="form-control"/>
                        </section>

                        <section class="input-group">
                            <label for="cost" class="form-label">Cost</label>
                            <input v-model="weaponCost" type="text" class="form-control"/>
                        </section>

                        <section class="input-group">
                            <label for="inUse" class="form-label">In use</label>
                            <input v-model="inUse" type="text" class="form-control" placeholder="True/False">
                        </section>

                        <input @click="changeWeapon" type="button" value="Save" class="btn btn-success">
                        <input @click="postWeapon" type="button" value="Add" class="btn btn-primary">
                        <input @click="deleteWeapon" type="button" value="Delete" class="btn btn-danger">
                    </form>
                </section> 
            </section>
        </section>
    </section>
    </section>
</template>

<script>
import weaponService from "../../services/weaponService.js"
import {reactive, toRefs} from 'vue'


export default {
  setup(){
       
       const weaponForm = reactive({
            weaponId: "",
            weaponName: "",
            weaponCost: "",
            inUse: false
        });

        const getWeapon = async () => {
            const weapon = await weaponService.getById(weaponForm.weaponId);
            weaponForm.weaponName = weapon.weaponName;
            weaponForm.weaponCost = weapon.weaponCost;
            weaponForm.inUse = weapon.inUse;           
        }

        const changeWeapon = async () => {

            const editedWeapon = {
                weaponId: parseInt( weaponForm.weaponId ),
                weaponName: weaponForm.weaponName,
                weaponCost: parseInt( weaponForm.weaponCost ),
                inUse: JSON.parse( weaponForm.inUse )
            }

            weaponService.putWeapon( editedWeapon );
            
            
        }

        const postWeapon = () => {

            const newWeapon = {
                weaponName: weaponForm.weaponName,
                weaponCost: parseInt( weaponForm.weaponCost ),
                inUse: JSON.parse( weaponForm.inUse )
            };

            weaponService.postWeapon ( newWeapon );
        }

        const deleteWeapon = async () => {
            
            weaponService.deleteWeapon(weaponForm.weaponId);
            
        }

        
        return{
          getWeapon,
          deleteWeapon,
          changeWeapon,
          postWeapon,
          ...toRefs( weaponForm )
      }
    },
    
    components: { 
    },
  
}
</script>

<style scoped>

    *{
        color: #FFF;
    }

    h2{
        margin-top: -30px;
        padding-top: 20px;
    }

    input{
        color: black;
        margin: 5px;
    }

    label{
        margin: 15px 5px;
    }

    .spacingTop{
        padding-top: 2rem;
    }

</style>