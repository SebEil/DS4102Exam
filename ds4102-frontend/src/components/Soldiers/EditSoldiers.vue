<template>
    <section> <h2 class="spacingTop">Soldier Editing</h2>
    <section id="inputSection">
        <section class="container-lg">
            <section class="row justify-content-center">
                <section class="col-lg-3">
                    <form>
                        <section class="input-group">
                            <label for="id" class="form-label">Id</label>
                            <input v-model="soldierId" type="text" class="form-control" id="id" placeholder="Type in ID and press 'Get'"/>
                            <input @click="getSoldier" type="button" value="Get" class="btn btn-primary">
                        </section>
                        
                        <section class="input-group">
                            <label for="name" class="form-label">SoldierName</label>
                            <input v-model="soldierName" type="text" class="form-control"/>
                        </section>

                        <section class="input-group">
                            <label for="bloodtype" class="form-label">Bloodtype</label>
                            <input v-model="bloodtype" type="text" class="form-control"/>
                        </section>

                        <section class="input-group">
                            <label for="height" class="form-label">Soldiers height</label>
                            <input v-model="height" type="text" class="form-control">
                        </section>

                         <section class="input-group">
                            <label for="image" class="form-label">Image</label>
                            <input @change="setImage" type="file" class="form-control">
                        </section>
                        
                        <section class="input-group">
                            <label for="isOnMission" class="form-label">Is on mission</label>
                            <input v-model="isOnMission" type="text" class="form-control">
                        </section>

                        <input @click="changeoldier" type="button" value="Save" class="btn btn-success">
                        <input @click="postSoldier" type="button" value="Add" class="btn btn-primary">
                        <input @click="deleteSoldier" type="button" value="Delete" class="btn btn-danger">
                    </form>
                </section> 
            </section>
        </section>
    </section>
    </section>
</template>

<script>
import soldierService from "../../services/soldierService.js"
import {reactive, toRefs} from 'vue'


export default {
  setup(){

      const image = new FormData();
       
       const soldierForm = reactive({
            soldierId: "",
            soldierName: "",
            bloodtype: "",
            height: 180,
            image: "",
            isOnMission: true
        });

        const setImage = (e) => {
            image.append("file", e.target.files[0]);
            soldierForm.image = e.target.files[0].name;
        }

        const getSoldier= async () => {
            const soldier = await soldierService.getById(soldierForm.soldierId);
            soldierForm.soldierName = soldier.soldierName;
            soldierForm.bloodtype = soldier.bloodtype;
            soldierForm.height = soldier.height;
            soldierForm.image = soldier.image; 
            soldierForm.isOnMission= soldier.isOnMission;            
        }

        const changeSoldier = async () => {

            const editedSoldier = {
                soldierId: parseInt( soldierForm.soldierId ),
                soldierName: soldierForm.soldierName,
                bloodtype: soldierForm.bloodtype,
                height: parseInt( soldierForm.height),
                image: soldierForm.image,
                isOnMission: JSON.parse(soldierForm.isOnMission)
            }

            soldierService.putSoldier( editedSoldier );
                 
        }

        const postSoldier = () => {

            const newSoldier = {
                soldierName: soldierForm.soldierName,
                bloodtype: soldierForm.bloodtype,
                height: parseInt( soldierForm.height),
                image: soldierForm.image,
                isOnMission: JSON.parse(soldierForm.isOnMission)
            };

            soldierService.postSoldier ( newSoldier, image );
        }

        const deleteSoldier = async () => {
            
            soldierService.deleteSoldier(soldierForm.soldierId);
            

        }

        
        return{
          getSoldier,
          deleteSoldier,
          changeSoldier,
          postSoldier,
          setImage,
          ...toRefs( soldierForm )
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